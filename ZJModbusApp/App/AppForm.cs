using System;
using System.Windows.Forms;
using ZJModbus.App.Entities;

namespace ZJModbus.App
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void MenuItem_Setting_Click(object sender, EventArgs e)
        {
            SettingForm frm = new SettingForm();
            var result = frm.ShowDialog();
            if(DialogResult.OK == result)
            {
                InitForm();
            }
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitViewMenuItems(string[] devices)
        {
            MenuItem_View.DropDownItems.Clear();

            foreach (var d in devices)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(string.Format("设备：{0}",d));
                item.Tag = d;
                item.Click += View_Item_Click;
                MenuItem_View.DropDownItems.Add(item);
            }

        }

        private void View_Item_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            ViewForm frm = new ViewForm();
            frm.Tag = item.Tag;
            frm.MdiParent = this;
            frm.Show();
        }

        private void InitStatusLables(AppSetting setting)
        {
            StatusLabel_DeviceCount.Text = string.Format("监控设备数量：{0}",setting.Devices.Length);
        }
        
        private void InitForm()
        {
            SetStatusLabelNow();
            var setting = AppSetting.Load();
            if (null != setting)
            {
                InitViewMenuItems(setting.Devices);
                InitStatusLables(setting);
            }
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定要退出程序吗？", "问题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            SetStatusLabelNow();
        }
        private void SetStatusLabelNow()
        {
            StatusLabel_Now.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("确定要退出程序吗？", "问题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }

        private void SetStatusLabelRunStatus(string text)
        {
           StatusLabel_RunStatus.Text = text;
        }

        private void MenuItem_Start_Click(object sender, EventArgs e)
        {
            AppSetting setting = AppSetting.Load();
            if (null == setting)
            {
                var result = MessageBox.Show("请先设置相关设备信息", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (DialogResult.Yes == result)
                {
                    MenuItem_Setting_Click(sender, e);
                    MenuItem_Start_Click(sender, e);
                    return;
                }
                else
                    return;
            }
            MenuItem_Start.Text = "停止监测";
            SetStatusLabelRunStatus("监测中");
            MenuItem_Start.Click -= MenuItem_Start_Click;
            MenuItem_Start.Click += MenuItem_Stop_Click;
            StartDeviceQueryTimer(setting);
        }
        

        private void MenuItem_Stop_Click(object sender, EventArgs e)
        {
            MenuItem_Start.Text = "开始监测";
            SetStatusLabelRunStatus("监测停止");
            MenuItem_Start.Click -= MenuItem_Stop_Click;
            MenuItem_Start.Click += MenuItem_Start_Click;
            StopDeviceQueryTimer();
        }

        private void StartDeviceQueryTimer(AppSetting setting)
        {
            //DeviceQueryTimer.Interval = setting.Interval;

        }

        private void StopDeviceQueryTimer()
        {
            //DeviceQueryTimer.Enabled = false;
        }

    }
}
