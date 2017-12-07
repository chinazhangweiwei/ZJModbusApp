using System;
using System.IO.Ports;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ZJModbus.App.Attributes;
using ZJModbus.App.Entities;
using ZJModbus.App.Services;
using ZJModbus.App.Tools;

namespace ZJModbus.App
{
    public partial class ViewForm : Form, FormByteAdapter.SetFormCtls
    {
        public ViewForm()
        {
            InitializeComponent();
        }
        private const int BUFFER_LENGTH = 1024;
        private const int ERROR_COMMAND_NOT_EXIST = 1;
        private const int ERROR_MEMORY_ADDRESS_OUT_OF_RANGE = 2;
        private const int SLEEP_LENGTH = 600000;
        private int device_num = -1;
        //private int buffer_length = 0;
        private int except_buffer_length = 0;
        private int data_type = -1;
        private int cmd_index = 0;
        private byte[][] cmds = new byte[][] {
            AlarmEntity.DATA_CMD,
            AIEntity.DATA_CMD,
            DIEntity.DATA_CMD,
            AOEntity.DATA_CMD,
            DOEntity.DATA_CMD,
            BaseStatusEntity.DATA_CMD,
            SettingEntity.DATA_CMD,
            StartStopEntity.DATA_CMD,
        };
        private Type[] entityMap = {
            typeof(AlarmEntity),
            typeof(AIEntity),
            typeof(DIEntity),
            typeof(AOEntity),
            typeof(DOEntity),
            typeof(BaseStatusEntity),
            typeof(SettingEntity),
            typeof(StartStopEntity)
        };
        private ManualResetEvent note = new ManualResetEvent(true);
        private Thread worker;
        public Type getEntityType(int dataType)
        {
            if (dataType > entityMap.Length)
                return null;

            return entityMap[dataType];
        }
        private void ViewForm_Load(object sender, EventArgs e)
        {
            var setting = AppSetting.Load();
            Sport.PortName = setting.PortName;
            Sport.Parity = setting.Parity;
            Sport.BaudRate = setting.Boude;
            Sport.StopBits = setting.StopBit;
            Sport.DataReceived += Sport_DataReceived;

            Text = string.Format("{0}号设备信息", Tag);
            device_num = Convert.ToInt32(Tag);
            worker = new Thread(new ThreadStart(() =>
            {
                WorkerTask();
            }));
            worker.IsBackground = true;
            worker.Start();
        }

        private void ThreadSendCommand(int deviceNum)
        {
            var type = MethodBase.GetCurrentMethod().DeclaringType;
            if (cmds.Length <= cmd_index)
            {
                cmd_index = 0;
                Thread.Sleep(SLEEP_LENGTH);
            }
            LogHelper.WriteLog(type, string.Format("发送指令{0}", cmd_index));
            data_type = cmd_index;
            cmds[cmd_index][0] = (byte)deviceNum;
            except_buffer_length = ((cmds[cmd_index][4] & 0xFF00) + cmds[cmd_index][5]) * 2 + 5;
            var cmdbytes = BytesCheckService.GetCRC16Full(cmds[cmd_index], true);
            if (!Sport.IsOpen)
            {
                Sport.Open();
            }
            Sport.Write(cmdbytes, 0, cmdbytes.Length);
        }
        private void WorkerTask()
        {
            while (true)
            {
                note.WaitOne();
                note.Reset();
                ThreadSendCommand(device_num);
            }
        }
        private void Sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (except_buffer_length < Sport.BytesToRead)
            {
                var type = MethodBase.GetCurrentMethod().DeclaringType;
                Sport.Close();
                data_type = -1;
                LogHelper.WriteLog(type, "释放Note");
                note.Set();
            }
            else if (except_buffer_length == Sport.BytesToRead)
            {
                var type = MethodBase.GetCurrentMethod().DeclaringType;
                LogHelper.WriteLog(type, string.Format("串口收到数据：{0}", except_buffer_length));
                byte[] bf = new byte[Sport.BytesToRead];
                Sport.Read(bf, 0, Sport.BytesToRead);
                FormByteAdapter.Adapter(data_type, bf, this);
                LogHelper.WriteLog(type, "数据解析完毕");
                cmd_index++;
                data_type = -1;
                LogHelper.WriteLog(type, "释放Note");
                note.Set();
            }
            else if (5 == Sport.BytesToRead)
            {
                var type = MethodBase.GetCurrentMethod().DeclaringType;
                LogHelper.WriteLog(type, "串口返回错误信息");
                //命令错误
                byte[] bf = new byte[Sport.BytesToRead];
                Sport.Read(bf, 0, 5);
                int i = bf[2] & 0xFF;
                if (ERROR_COMMAND_NOT_EXIST == i)
                {
                    LogHelper.WriteLog(type, "命令不存在......");
                }
                else if (ERROR_MEMORY_ADDRESS_OUT_OF_RANGE == i)
                {
                    LogHelper.WriteLog(type, "数据地址越界......");
                    //Invoke((EventHandler)delegate
                    //{
                    //    MessageBox.Show("数据地址越界......", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //});
                }
                else
                {
                    LogHelper.WriteLog(type, string.Format("发生未知错误......{0}", i));
                }
                data_type = -1;
                LogHelper.WriteLog(type, "释放Note");
                note.Set();
            }
        }

        public void SetCtls(BaseStatusEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_Base.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    LV_Base.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0}", p.GetValue(entity)) }));
                }
            }
        }

        public void SetCtls(AIEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_AI.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_AI.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0}{1}", p.GetValue(entity), desc.Unit) }));
                    }
                }
            }
        }

        public void SetCtls(SettingEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_Setting.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_Setting.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0}{1}", p.GetValue(entity), desc.Unit) }));
                    }
                }
            }
        }

        public void SetCtls(AOEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_AO.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_AO.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0}{1}", p.GetValue(entity), desc.Unit) }));
                    }
                }
            }
        }

        public void SetCtls(DIEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_DI.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    var str = Convert.ToBoolean(p.GetValue(entity)) ? "√" : "×";
                    {
                        LV_DI.Items.Add(new ListViewItem(new string[] { desc.Name, str }));
                    }
                }
            }
        }

        public void SetCtls(DOEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_DO.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    var str = Convert.ToBoolean(p.GetValue(entity)) ? "√" : "×";
                    {
                        LV_DO.Items.Add(new ListViewItem(new string[] { desc.Name, str }));
                    }
                }
            }
        }

        public void SetCtls(AlarmEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_Alarm.Items.Clear();
            var properties = entity.GetType().GetProperties();
            var now = DateTime.Now;
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_Alarm.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0:HH:mm:ss}", now) }));
                    }
                }
            }
        }

        public void SetCtls(StartStopEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetCtls(entity);
                }));
                return;
            }
            LV_StartStop.Items.Clear();
            var properties = entity.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if (null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    LV_StartStop.Items.Add(new ListViewItem(new string[] { desc.Name, p.GetValue(entity).ToString() }));
                }
            }
        }
    }
}