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
        private const int SLEEP_LENGTH = 60000;
        private int device_num = -1;
        private int buffer_length = 0;
        private int except_buffer_length = 0;
        private int data_type = -1;
        private int cmd_index = 0;
        private byte[] bf;
        private byte[][] cmds = new byte[][] {
            new byte[]{ 0x0,0x3,0x7,0xA0,0x0,0x25},
            new byte[]{ 0x0,0x3,0x1,0x0,0x0,0x29},
            new byte[]{ 0x0,0x3,0x2,0x0,0x0,0x2A},
            new byte[]{ 0x0,0x3,0x3,0x0,0x0,0x6},
            new byte[]{ 0x0,0x3,0x4,0x0,0x0,0x38}
        };
        private Type[] entityMap = {
            typeof(AlarmEntity),
            typeof(AIEntity),
            typeof(DIEntity),
            typeof(AOEntity),
            typeof(DOEntity)
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
            bf = new byte[BUFFER_LENGTH];

            var setting = AppSetting.Load();
            Sport.PortName = setting.PortName;
            Sport.Parity = setting.Parity;
            Sport.BaudRate = setting.Boude;
            Sport.StopBits = setting.StopBit;
            Sport.DataReceived += Sport_DataReceived;

            Text = string.Format("{0}号设备信息",Tag);
            device_num = Convert.ToInt32(Tag);
            worker = new Thread(new ThreadStart(()=> {
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
            except_buffer_length = ((cmds[cmd_index][4] & 0xFF00) + cmds[cmd_index][5])*2+5;
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
            if(except_buffer_length < Sport.BytesToRead)
            {
                var type = MethodBase.GetCurrentMethod().DeclaringType;
                Sport.Close();
                data_type = -1;
                LogHelper.WriteLog(type, "释放Note");
                note.Set();
            }
            else if(except_buffer_length == Sport.BytesToRead)
            {
                var type = MethodBase.GetCurrentMethod().DeclaringType;
                LogHelper.WriteLog(type, string.Format("串口收到数据：{0}", except_buffer_length));
                buffer_length = Sport.Read(bf, 0, BUFFER_LENGTH);
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
                buffer_length = Sport.Read(bf, 0, BUFFER_LENGTH);
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
                    LogHelper.WriteLog(type, string.Format("发生未知错误......{0}",i));
                }
                data_type = -1;
                LogHelper.WriteLog(type, "释放Note");
                note.Set();
            }
        }

        public void SetCtls(BaseStatusEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SetCtls(AIEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => {
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
                        LV_AI.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0}{1}",p.GetValue(entity), desc.Unit) }));
                    }
                }
            }
        }

        public void SetCtls(AOEntity entity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => {
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
                this.Invoke(new Action(() => {
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
                this.Invoke(new Action(() => {
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
                this.Invoke(new Action(()=> {
                    SetCtls(entity);
                }));
                return;
            }
            LV_Alarm.Items.Clear();
            var properties = entity.GetType().GetProperties();
            var now = DateTime.Now;
            foreach(var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if(null != attr)
                {
                    var desc = (DescriptionAttribute)attr;
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_Alarm.Items.Add(new ListViewItem(new string[] { desc.Name, string.Format("{0:HH:mm:ss}", now) }) );
                    }
                }
            }
        }

        
    }
}