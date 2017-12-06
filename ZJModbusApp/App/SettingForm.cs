using System;
using System.IO.Ports;
using System.Windows.Forms;
using ZJModbus.App.Entities;

namespace ZJModbus.App
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        private AppSetting setting;
        private bool hasSave = false;
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Com_List.Items.AddRange(SerialPort.GetPortNames());
            setting = AppSetting.Load();
            if(null != setting)
            {
                Com_List.Text = setting.PortName;
                Device_Boude.Text = setting.Boude.ToString();
                Data_Length.Text = setting.DataLength.ToString();
                Stop_Bit.SelectedIndex = (int)setting.StopBit;
                Data_Check.SelectedIndex = (int)setting.Parity;
                Intervar_Num.Value = setting.Interval;
                Device_List.Items.AddRange(setting.Devices);
            }
            else
            {
                setting = new AppSetting();
            }          
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                setting.PortName = Com_List.Text;
                setting.Boude = int.Parse(Device_Boude.Text);
                setting.DataLength = int.Parse(Data_Length.Text);
                setting.StopBit = (StopBits)Stop_Bit.SelectedIndex;
                setting.Parity = (Parity)Data_Check.SelectedIndex;
                setting.Interval = (int)Intervar_Num.Value;
                setting.Save();
                hasSave = true;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据输入错误或不完整，无法保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string txt = Txt_NewDevice_Num.Text;
            if (!string.IsNullOrEmpty(txt)){
                setting.AddDevice(txt);
                Device_List.Items.Add(txt);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Device_List.Items.Count;i++)
            {
                if (Device_List.GetItemChecked(i)){
                    setting.DeleteDevice(Device_List.Items[i].ToString());
                    Device_List.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hasSave)
            {
                DialogResult result = MessageBox.Show("确定要退出不保存吗？", "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == result)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
