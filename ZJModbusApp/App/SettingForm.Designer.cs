namespace ZJModbus.App
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Com_List = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Device_Boude = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.Stop_Bit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Data_Check = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Data_Length = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Device_List = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Txt_NewDevice_Num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Intervar_Num = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intervar_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "默认串口";
            // 
            // Com_List
            // 
            this.Com_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_List.FormattingEnabled = true;
            this.Com_List.Location = new System.Drawing.Point(70, 20);
            this.Com_List.Name = "Com_List";
            this.Com_List.Size = new System.Drawing.Size(144, 20);
            this.Com_List.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "波特率";
            // 
            // Device_Boude
            // 
            this.Device_Boude.Location = new System.Drawing.Point(286, 19);
            this.Device_Boude.Name = "Device_Boude";
            this.Device_Boude.Size = new System.Drawing.Size(144, 21);
            this.Device_Boude.TabIndex = 5;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(11, 63);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(41, 12);
            this.lab.TabIndex = 7;
            this.lab.Text = "结束位";
            // 
            // Stop_Bit
            // 
            this.Stop_Bit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stop_Bit.FormattingEnabled = true;
            this.Stop_Bit.Items.AddRange(new object[] {
            "无",
            "1",
            "1.5",
            "2"});
            this.Stop_Bit.Location = new System.Drawing.Point(70, 60);
            this.Stop_Bit.Name = "Stop_Bit";
            this.Stop_Bit.Size = new System.Drawing.Size(144, 20);
            this.Stop_Bit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "校验";
            // 
            // Data_Check
            // 
            this.Data_Check.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Data_Check.FormattingEnabled = true;
            this.Data_Check.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "校验位0",
            "校验位1"});
            this.Data_Check.Location = new System.Drawing.Point(286, 60);
            this.Data_Check.Name = "Data_Check";
            this.Data_Check.Size = new System.Drawing.Size(144, 20);
            this.Data_Check.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "数据位";
            // 
            // Data_Length
            // 
            this.Data_Length.Location = new System.Drawing.Point(508, 19);
            this.Data_Length.Name = "Data_Length";
            this.Data_Length.Size = new System.Drawing.Size(144, 21);
            this.Data_Length.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Com_List);
            this.groupBox1.Controls.Add(this.Data_Length);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Data_Check);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Device_Boude);
            this.groupBox1.Controls.Add(this.Stop_Bit);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Delete);
            this.groupBox2.Controls.Add(this.Device_List);
            this.groupBox2.Location = new System.Drawing.Point(239, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 149);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备列表";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(13, 117);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(181, 23);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "删除选中设备";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Device_List
            // 
            this.Device_List.FormattingEnabled = true;
            this.Device_List.Location = new System.Drawing.Point(13, 20);
            this.Device_List.Name = "Device_List";
            this.Device_List.Size = new System.Drawing.Size(186, 84);
            this.Device_List.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Add);
            this.groupBox3.Controls.Add(this.Txt_NewDevice_Num);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(477, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 149);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "新增设备";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(11, 117);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(181, 23);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "添加";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Txt_NewDevice_Num
            // 
            this.Txt_NewDevice_Num.Location = new System.Drawing.Point(11, 64);
            this.Txt_NewDevice_Num.Name = "Txt_NewDevice_Num";
            this.Txt_NewDevice_Num.Size = new System.Drawing.Size(180, 21);
            this.Txt_NewDevice_Num.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新设备号";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(585, 280);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(96, 23);
            this.Btn_Save.TabIndex = 16;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Intervar_Num);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 149);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设备状态更新时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "时间单位为：秒";
            // 
            // Intervar_Num
            // 
            this.Intervar_Num.Location = new System.Drawing.Point(13, 65);
            this.Intervar_Num.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.Intervar_Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Intervar_Num.Name = "Intervar_Num";
            this.Intervar_Num.Size = new System.Drawing.Size(180, 21);
            this.Intervar_Num.TabIndex = 17;
            this.Intervar_Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 315);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "系统设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intervar_Num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Com_List;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Device_Boude;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.ComboBox Stop_Bit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Data_Check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Data_Length;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox Device_List;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox Txt_NewDevice_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Intervar_Num;
    }
}