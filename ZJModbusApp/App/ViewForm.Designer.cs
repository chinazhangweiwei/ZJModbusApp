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
            this.LV_AI = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_DI = new System.Windows.Forms.TabPage();
            this.LV_DI = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_AO = new System.Windows.Forms.TabPage();
            this.LV_AO = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_DO = new System.Windows.Forms.TabPage();
            this.LV_DO = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_Setting = new System.Windows.Forms.TabPage();
            this.Page_BaseStatus = new System.Windows.Forms.TabPage();
            this.Sport = new System.IO.Ports.SerialPort(this.components);
            this.LV_Base = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.Page_Alarm.SuspendLayout();
            this.Page_AI.SuspendLayout();
            this.Page_DI.SuspendLayout();
            this.Page_AO.SuspendLayout();
            this.Page_DO.SuspendLayout();
            this.Page_BaseStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page_Alarm);
            this.tabControl1.Controls.Add(this.Page_AI);
            this.tabControl1.Controls.Add(this.Page_DI);
            this.tabControl1.Controls.Add(this.Page_AO);
            this.tabControl1.Controls.Add(this.Page_DO);
            this.tabControl1.Controls.Add(this.Page_Setting);
            this.tabControl1.Controls.Add(this.Page_BaseStatus);
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
            this.columnHeader5.Width = 300;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "报警时间";
            this.columnHeader6.Width = 200;
            // 
            // Page_AI
            // 
            this.Page_AI.Controls.Add(this.LV_AI);
            this.Page_AI.Location = new System.Drawing.Point(4, 22);
            this.Page_AI.Name = "Page_AI";
            this.Page_AI.Padding = new System.Windows.Forms.Padding(3);
            this.Page_AI.Size = new System.Drawing.Size(1107, 305);
            this.Page_AI.TabIndex = 1;
            this.Page_AI.Text = "模拟量输入信号（AI）";
            this.Page_AI.UseVisualStyleBackColor = true;
            // 
            // LV_AI
            // 
            this.LV_AI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.LV_AI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_AI.GridLines = true;
            this.LV_AI.Location = new System.Drawing.Point(3, 3);
            this.LV_AI.Name = "LV_AI";
            this.LV_AI.Size = new System.Drawing.Size(1101, 299);
            this.LV_AI.TabIndex = 1;
            this.LV_AI.UseCompatibleStateImageBehavior = false;
            this.LV_AI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "项目";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "值";
            // 
            // Page_DI
            // 
            this.Page_DI.Controls.Add(this.LV_DI);
            this.Page_DI.Location = new System.Drawing.Point(4, 22);
            this.Page_DI.Name = "Page_DI";
            this.Page_DI.Padding = new System.Windows.Forms.Padding(3);
            this.Page_DI.Size = new System.Drawing.Size(1107, 305);
            this.Page_DI.TabIndex = 2;
            this.Page_DI.Text = "开关量输入信号（DI）";
            this.Page_DI.UseVisualStyleBackColor = true;
            // 
            // LV_DI
            // 
            this.LV_DI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.LV_DI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_DI.GridLines = true;
            this.LV_DI.Location = new System.Drawing.Point(3, 3);
            this.LV_DI.Name = "LV_DI";
            this.LV_DI.Size = new System.Drawing.Size(1101, 299);
            this.LV_DI.TabIndex = 2;
            this.LV_DI.UseCompatibleStateImageBehavior = false;
            this.LV_DI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "项目";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "值";
            // 
            // Page_AO
            // 
            this.Page_AO.Controls.Add(this.LV_AO);
            this.Page_AO.Location = new System.Drawing.Point(4, 22);
            this.Page_AO.Name = "Page_AO";
            this.Page_AO.Padding = new System.Windows.Forms.Padding(3);
            this.Page_AO.Size = new System.Drawing.Size(1107, 305);
            this.Page_AO.TabIndex = 3;
            this.Page_AO.Text = "模拟量输出信号（AO）";
            this.Page_AO.UseVisualStyleBackColor = true;
            // 
            // LV_AO
            // 
            this.LV_AO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.LV_AO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_AO.GridLines = true;
            this.LV_AO.Location = new System.Drawing.Point(3, 3);
            this.LV_AO.Name = "LV_AO";
            this.LV_AO.Size = new System.Drawing.Size(1101, 299);
            this.LV_AO.TabIndex = 2;
            this.LV_AO.UseCompatibleStateImageBehavior = false;
            this.LV_AO.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "项目";
            this.columnHeader7.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "值";
            // 
            // Page_DO
            // 
            this.Page_DO.Controls.Add(this.LV_DO);
            this.Page_DO.Location = new System.Drawing.Point(4, 22);
            this.Page_DO.Name = "Page_DO";
            this.Page_DO.Size = new System.Drawing.Size(1107, 305);
            this.Page_DO.TabIndex = 4;
            this.Page_DO.Text = "开关量输出信号（DO）";
            this.Page_DO.UseVisualStyleBackColor = true;
            // 
            // LV_DO
            // 
            this.LV_DO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.LV_DO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_DO.GridLines = true;
            this.LV_DO.Location = new System.Drawing.Point(0, 0);
            this.LV_DO.Name = "LV_DO";
            this.LV_DO.Size = new System.Drawing.Size(1107, 305);
            this.LV_DO.TabIndex = 3;
            this.LV_DO.UseCompatibleStateImageBehavior = false;
            this.LV_DO.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "项目";
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "值";
            // 
            // Page_Setting
            // 
            this.Page_Setting.Location = new System.Drawing.Point(4, 22);
            this.Page_Setting.Name = "Page_Setting";
            this.Page_Setting.Size = new System.Drawing.Size(1107, 305);
            this.Page_Setting.TabIndex = 5;
            this.Page_Setting.Text = "设定参数";
            this.Page_Setting.UseVisualStyleBackColor = true;
            // 
            // Page_BaseStatus
            // 
            this.Page_BaseStatus.Controls.Add(this.LV_Base);
            this.Page_BaseStatus.Location = new System.Drawing.Point(4, 22);
            this.Page_BaseStatus.Name = "Page_BaseStatus";
            this.Page_BaseStatus.Padding = new System.Windows.Forms.Padding(3);
            this.Page_BaseStatus.Size = new System.Drawing.Size(1107, 305);
            this.Page_BaseStatus.TabIndex = 6;
            this.Page_BaseStatus.Text = "基本状态信息";
            this.Page_BaseStatus.UseVisualStyleBackColor = true;
            // 
            // LV_Base
            // 
            this.LV_Base.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.LV_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Base.GridLines = true;
            this.LV_Base.Location = new System.Drawing.Point(3, 3);
            this.LV_Base.Name = "LV_Base";
            this.LV_Base.Size = new System.Drawing.Size(1101, 299);
            this.LV_Base.TabIndex = 3;
            this.LV_Base.UseCompatibleStateImageBehavior = false;
            this.LV_Base.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "项目";
            this.columnHeader11.Width = 300;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "值";
            this.columnHeader12.Width = 200;
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
            this.Page_DI.ResumeLayout(false);
            this.Page_AO.ResumeLayout(false);
            this.Page_DO.ResumeLayout(false);
            this.Page_BaseStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page_Alarm;
        private System.Windows.Forms.TabPage Page_AI;
        private System.Windows.Forms.ListView LV_Alarm;
        private System.Windows.Forms.ListView LV_AI;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.IO.Ports.SerialPort Sport;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage Page_DI;
        private System.Windows.Forms.TabPage Page_AO;
        private System.Windows.Forms.TabPage Page_DO;
        private System.Windows.Forms.TabPage Page_Setting;
        private System.Windows.Forms.TabPage Page_BaseStatus;
        private System.Windows.Forms.ListView LV_DI;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView LV_AO;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView LV_DO;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView LV_Base;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}