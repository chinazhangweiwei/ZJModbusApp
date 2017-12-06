namespace ZJModbus.App
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu_Main = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_Main = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_RunStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_DeviceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_Alarm = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_Now = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.Menu_Main.SuspendLayout();
            this.Status_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Main
            // 
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_View});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(1243, 25);
            this.Menu_Main.TabIndex = 0;
            this.Menu_Main.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Start,
            this.MenuItem_Setting,
            this.toolStripSeparator1,
            this.MenuItem_Exit});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_File.Text = "文件";
            // 
            // MenuItem_Start
            // 
            this.MenuItem_Start.Name = "MenuItem_Start";
            this.MenuItem_Start.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Start.Text = "开始监测";
            this.MenuItem_Start.Click += new System.EventHandler(this.MenuItem_Start_Click);
            // 
            // MenuItem_Setting
            // 
            this.MenuItem_Setting.Name = "MenuItem_Setting";
            this.MenuItem_Setting.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Setting.Text = "设置";
            this.MenuItem_Setting.Click += new System.EventHandler(this.MenuItem_Setting_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_Exit.Text = "退出";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // MenuItem_View
            // 
            this.MenuItem_View.Name = "MenuItem_View";
            this.MenuItem_View.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_View.Text = "视图";
            // 
            // Status_Main
            // 
            this.Status_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_RunStatus,
            this.StatusLabel_DeviceCount,
            this.StatusLabel_Alarm,
            this.StatusLabel_Now});
            this.Status_Main.Location = new System.Drawing.Point(0, 333);
            this.Status_Main.Name = "Status_Main";
            this.Status_Main.Size = new System.Drawing.Size(1243, 26);
            this.Status_Main.TabIndex = 2;
            this.Status_Main.Text = "statusStrip1";
            // 
            // StatusLabel_RunStatus
            // 
            this.StatusLabel_RunStatus.AutoSize = false;
            this.StatusLabel_RunStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabel_RunStatus.Name = "StatusLabel_RunStatus";
            this.StatusLabel_RunStatus.Size = new System.Drawing.Size(200, 21);
            this.StatusLabel_RunStatus.Text = "监测停止";
            // 
            // StatusLabel_DeviceCount
            // 
            this.StatusLabel_DeviceCount.AutoSize = false;
            this.StatusLabel_DeviceCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabel_DeviceCount.Name = "StatusLabel_DeviceCount";
            this.StatusLabel_DeviceCount.Size = new System.Drawing.Size(300, 21);
            this.StatusLabel_DeviceCount.Text = "连接设备数量：";
            // 
            // StatusLabel_Alarm
            // 
            this.StatusLabel_Alarm.AutoSize = false;
            this.StatusLabel_Alarm.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabel_Alarm.Name = "StatusLabel_Alarm";
            this.StatusLabel_Alarm.Size = new System.Drawing.Size(300, 21);
            // 
            // StatusLabel_Now
            // 
            this.StatusLabel_Now.AutoSize = false;
            this.StatusLabel_Now.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabel_Now.Name = "StatusLabel_Now";
            this.StatusLabel_Now.Size = new System.Drawing.Size(200, 21);
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Interval = 1000;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 359);
            this.Controls.Add(this.Status_Main);
            this.Controls.Add(this.Menu_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu_Main;
            this.Name = "AppForm";
            this.Text = "控制程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.Menu_Main.ResumeLayout(false);
            this.Menu_Main.PerformLayout();
            this.Status_Main.ResumeLayout(false);
            this.Status_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Main;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.StatusStrip Status_Main;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_DeviceCount;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_View;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Alarm;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Now;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Start;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_RunStatus;
    }
}