namespace ZJModbus.App
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sport = new System.IO.Ports.SerialPort(this.components);
            this.comlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_open = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datalist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comlist
            // 
            this.comlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comlist.FormattingEnabled = true;
            this.comlist.Location = new System.Drawing.Point(349, 12);
            this.comlist.Name = "comlist";
            this.comlist.Size = new System.Drawing.Size(152, 20);
            this.comlist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "可用串口";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(522, 10);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "打开串口";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(15, 45);
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(486, 21);
            this.txt_cmd.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(518, 43);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "发送数据";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "返回数据";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(15, 99);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(578, 79);
            this.txt_result.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "返回数据解析";
            // 
            // txt_open
            // 
            this.txt_open.Location = new System.Drawing.Point(12, 215);
            this.txt_open.Multiline = true;
            this.txt_open.Name = "txt_open";
            this.txt_open.Size = new System.Drawing.Size(578, 79);
            this.txt_open.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "要获取的数据";
            // 
            // datalist
            // 
            this.datalist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datalist.FormattingEnabled = true;
            this.datalist.Items.AddRange(new object[] {
            "基本状态",
            "报警信息",
            "开关量",
            "模拟量"});
            this.datalist.Location = new System.Drawing.Point(98, 12);
            this.datalist.Name = "datalist";
            this.datalist.Size = new System.Drawing.Size(166, 20);
            this.datalist.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 306);
            this.Controls.Add(this.datalist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "中佳Modbus数据协议分析程序";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort sport;
        private System.Windows.Forms.ComboBox comlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox datalist;
    }
}

