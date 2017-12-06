using System;
using System.IO.Ports;
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
        private int device_num = -1;
        private int buffer_length = 0;
        private int except_buffer_length = 0;
        private int data_type = -1;
        private int cmd_index = 0;
        private byte[] bf;
        private byte[][] cmds = new byte[][] {
            new byte[]{ 0x0,0x3,0x7,0xA0,0x0,0x25},
            new byte[]{ 0x0,0x3,0x1,0x0,0x0,0x42}
        };
        private object lockObject = new object();
        private Thread worker;

        private void ViewForm_Load(object sender, EventArgs e)
        {
            bf = new byte[BUFFER_LENGTH];

            var setting = AppSetting.Load();
            Sport.PortName = setting.PortName;
            Sport.Parity = setting.Parity;
            Sport.BaudRate = setting.Boude;
            Sport.StopBits = setting.StopBit;
            Sport.DataReceived += Sport_DataReceived;
            Sport.Open();

            Text = string.Format("{0}号设备信息",Tag);
            device_num = Convert.ToInt32(Tag);
            worker = new Thread(new ThreadStart(()=> {
                WorkerTask();
            }));
            worker.IsBackground = true;
            worker.Start();
        }

        private void SendCommand(int deviceNum,int cmdIndex)
        {
            if (!Sport.IsOpen)
            {
                MessageBox.Show("请先打开串口设备", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            data_type = cmdIndex;
            cmds[cmdIndex][0] = (byte)deviceNum;
            
            var cmdbytes = BytesCheckService.GetCRC16Full(cmds[cmdIndex], true);

            Sport.Write(cmdbytes, 0, cmdbytes.Length);
        }

        private void Sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Monitor.Enter(lockObject);
            int len = Sport.BytesToRead;
            if (5 < len)
            {
                buffer_length = Sport.Read(bf, 0, BUFFER_LENGTH);
                int i = bf[2] & 0xFF;
                if ((i + 5) == len)
                {
                    FormByteAdapter.Adapter(data_type, bf, this);
                    cmd_index++;
                }
            }
            else if (5 == len)
            {
                //命令错误
                int i = bf[3] & 0xFF;
                if (ERROR_COMMAND_NOT_EXIST == i)
                {
                    MessageBox.Show("命令不存在......", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ERROR_MEMORY_ADDRESS_OUT_OF_RANGE == i)
                {
                    MessageBox.Show("数据地址越界......", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("发生未知错误......", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            data_type = -1;
            Monitor.Pulse(lockObject);
            Monitor.Exit(lockObject);
        }

        public void SetCtls(BaseStatusEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SetCtls(AlEmtity entity)
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
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_DI.Items.Add(new ListViewItem(new string[] { desc.Name, p.GetValue(entity).ToString(), desc.Unit }));
                    }
                }
            }
        }

        public void SetCtls(AOEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SetCtls(DIEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SetCtls(DOEntity entity)
        {
            throw new NotImplementedException();
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
            foreach(var p in properties)
            {
                var attr = Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute));
                if(null != attr)
                {
                    if (Convert.ToBoolean(p.GetValue(entity)))
                    {
                        LV_Alarm.Items.Add(((DescriptionAttribute)attr).Name);
                    }
                }
            }
        }

        private void WorkerTask()
        {
            while (true)
            {
                Monitor.Enter(lockObject);
                if (cmds.Length <= cmd_index)
                    cmd_index = 0;

                SendCommand(device_num, cmd_index);
                Monitor.Pulse(lockObject);
                Monitor.Wait(lockObject);
            }
        }
        
    }
}