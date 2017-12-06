using System;
using System.IO.Ports;
using System.Windows.Forms;
using ZJModbus.App.Entities;
using ZJModbus.App.Services;
using static ZJModbus.App.Tools.FormByteAdapter;

namespace ZJModbus.App
{
    public partial class MainForm : Form ,SetFormCtls
    {
        private const int BUFFER_LENGTH = 1024;
        private const int ERROR_COMMAND_NOT_EXIST = 1;
        private const int ERROR_MEMORY_ADDRESS_OUT_OF_RANGE = 2;
        private int buffer_length = 0;
        private int except_buffer_length = 0;
        private int data_type_index = -1;
        public MainForm()
        {
            InitializeComponent();
        }
        byte[] bf;
        private void MainForm_Load(object sender, EventArgs e)
        {
            comlist.Items.AddRange(SerialPort.GetPortNames());
            bf = new byte[BUFFER_LENGTH];
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(datalist.Text))
            {
                MessageBox.Show("请选择要获取的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            data_type_index = datalist.SelectedIndex;

            if (string.IsNullOrEmpty(comlist.Text))
            {
                MessageBox.Show("请选择要打开的串口", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sport.PortName.Equals(comlist.Text) && sport.IsOpen)
            {
                return;
            }
            sport.PortName = comlist.Text;
            sport.Parity = Parity.None;
            sport.BaudRate = 9600;
            sport.StopBits = StopBits.One;
            //sport.RtsEnable = true;
            //sport.Handshake = Handshake.RequestToSend;
            comlist.Enabled = false;
            btn_open.Text = "关闭串口";
            btn_open.Click -= btn_open_Click;
            btn_open.Click += btn_close_Click;

            sport.DataReceived += Sport_DataReceived;
            sport.Open();
            btn_send.Enabled = true;
        }

        private void Sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = sport.BytesToRead;
            if (5 < len)
            {
                buffer_length = sport.Read(bf, 0, BUFFER_LENGTH);
                int i = bf[2] & 0xFF;
                if ((i + 5) == len)
                {
                    Adapter(data_type_index, bf, this);
                }
            }else if(5 == len)
            {
                //命令错误
                int i = bf[3] & 0xFF;
                if(ERROR_COMMAND_NOT_EXIST == i)
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
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (sport.IsOpen)
            {
                sport.Close();
                btn_send.Enabled = false;
                comlist.Enabled = true;
                btn_open.Text = "打开串口";
                btn_open.Click += btn_open_Click;
                btn_open.Click -= btn_close_Click;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (!sport.IsOpen)
            {
                MessageBox.Show("请先打开串口设备", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }                
            string cmd = txt_cmd.Text;
            if(cmd.Length!=12)
            {
                MessageBox.Show("设备命令长度错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] cmdbytes = new byte[6];
            //01 03 00 01 00 01 xx xx
            
            for(int i = 0; i < 6; i++)
            {
                cmdbytes[i] = (byte)int.Parse(cmd.Substring(i*2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            }
            cmdbytes = BytesCheckService.GetCRC16Full(cmdbytes, true);
            sport.Write(cmdbytes, 0, cmdbytes.Length);
        }

        public void SetCtls(BaseStatusEntity entity)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => {
                    SetCtls(entity);
                }));
                return;
            }
            txt_open.Clear();
            txt_open.Text = string.Format("燃料类型：{0}\r\n介质类型：{1}\r\n运行状态：{2}\r\n设定状态：{3}\r\n当前时间：{4:yy-MM-dd HH:mm:ss}",
                entity.TheFuelType,entity.TheMediumType,entity.TheRunStatus,entity.TheSettingStutus,entity.Now);
        }

        public void SetCtls(AIEntity entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Type getEntityType(int dataType)
        {
            throw new NotImplementedException();
        }
    }
}
