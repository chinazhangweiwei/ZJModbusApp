namespace ZJModbus.App
{
    partial class ViewForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page_Alarm = new System.Windows.Forms.TabPage();
            this.LV_Alarm = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_AI = new System.Windows.Forms.TabPage();
            this.LV_DI = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sport = new System.IO.Ports.SerialPort(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.Page_Alarm.SuspendLayout();
            this.Page_AI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page_Alarm);
            this.tabControl1.Controls.Add(this.Page_AI);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 331);
            this.tabControl1.TabIndex = 1;
            // 
            // Page_Alarm
            // 
            this.Page_Alarm.Controls.Add(this.LV_Alarm);
            this.Page_Alarm.Location = new System.Drawing.Point(4, 22);
            this.Page_Alarm.Name = "Page_Alarm";
            this.Page_Alarm.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Alarm.Size = new System.Drawing.Size(1107, 305);
            this.Page_Alarm.TabIndex = 0;
            this.Page_Alarm.Text = "报警信息";
            this.Page_Alarm.UseVisualStyleBackColor = true;
            // 
            // LV_Alarm
            // 
            this.LV_Alarm.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LV_Alarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.LV_Alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Alarm.FullRowSelect = true;
            this.LV_Alarm.GridLines = true;
            this.LV_Alarm.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.LV_Alarm.Location = new System.Drawing.Point(3, 3);
            this.LV_Alarm.MultiSelect = false;
            this.LV_Alarm.Name = "LV_Alarm";
            this.LV_Alarm.ShowGroups = false;
            this.LV_Alarm.Size = new System.Drawing.Size(1101, 299);
            this.LV_Alarm.TabIndex = 0;
            this.LV_Alarm.UseCompatibleStateImageBehavior = false;
            this.LV_Alarm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "警报信息";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "报警时间";
            // 
            // Page_AI
            // 
            this.Page_AI.Controls.Add(this.LV_DI);
            this.Page_AI.Location = new System.Drawing.Point(4, 22);
            this.Page_AI.Name = "Page_AI";
            this.Page_AI.Padding = new System.Windows.Forms.Padding(3);
            this.Page_AI.Size = new System.Drawing.Size(1107, 305);
            this.Page_AI.TabIndex = 1;
            this.Page_AI.Text = "模拟量输入信号";
            this.Page_AI.UseVisualStyleBackColor = true;
            // 
            // LV_DI
            // 
            this.LV_DI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.LV_DI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_DI.GridLines = true;
            this.LV_DI.Location = new System.Drawing.Point(3, 3);
            this.LV_DI.Name = "LV_DI";
            this.LV_DI.Size = new System.Drawing.Size(1101, 299);
            this.LV_DI.TabIndex = 1;
            this.LV_DI.UseCompatibleStateImageBehavior = false;
            this.LV_DI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "项目";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "单位";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "值";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewForm";
            this.Text = "设备信息";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Page_Alarm.ResumeLayout(false);
            this.Page_AI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page_Alarm;
        private System.Windows.Forms.TabPage Page_AI;
        private System.Windows.Forms.ListView LV_Alarm;
        private System.Windows.Forms.ListView LV_DI;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.IO.Ports.SerialPort Sport;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}