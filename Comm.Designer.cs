namespace SerialTransmission
{
    partial class Comm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.com_jyw = new System.Windows.Forms.ComboBox();
            this.lbl_jyw = new System.Windows.Forms.Label();
            this.com_state = new System.Windows.Forms.RadioButton();
            this.lbl_state = new System.Windows.Forms.Label();
            this.com_open = new System.Windows.Forms.Button();
            this.com_stop = new System.Windows.Forms.ComboBox();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.com_data = new System.Windows.Forms.ComboBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.com_bps = new System.Windows.Forms.ComboBox();
            this.lbl_bps = new System.Windows.Forms.Label();
            this.com_port = new System.Windows.Forms.ComboBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IsLine = new System.Windows.Forms.CheckBox();
            this.IsTime = new System.Windows.Forms.CheckBox();
            this.receive_FileSrc = new System.Windows.Forms.TextBox();
            this.receive_file = new System.Windows.Forms.Button();
            this.receive_save = new System.Windows.Forms.CheckBox();
            this.receive_clean = new System.Windows.Forms.Button();
            this.receive_hex = new System.Windows.Forms.RadioButton();
            this.receive_ascii = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.send_clean = new System.Windows.Forms.Button();
            this.send_file = new System.Windows.Forms.Button();
            this.send_hex = new System.Windows.Forms.RadioButton();
            this.send_ascii = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bt_ReceiveData = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_SendData = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.send_num = new System.Windows.Forms.ToolStripStatusLabel();
            this.num1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.received_num = new System.Windows.Forms.ToolStripStatusLabel();
            this.num2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.com_jyw);
            this.groupBox1.Controls.Add(this.lbl_jyw);
            this.groupBox1.Controls.Add(this.com_state);
            this.groupBox1.Controls.Add(this.lbl_state);
            this.groupBox1.Controls.Add(this.com_open);
            this.groupBox1.Controls.Add(this.com_stop);
            this.groupBox1.Controls.Add(this.lbl_stop);
            this.groupBox1.Controls.Add(this.com_data);
            this.groupBox1.Controls.Add(this.lbl_data);
            this.groupBox1.Controls.Add(this.com_bps);
            this.groupBox1.Controls.Add(this.lbl_bps);
            this.groupBox1.Controls.Add(this.com_port);
            this.groupBox1.Controls.Add(this.lbl_port);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口配置";
            // 
            // com_jyw
            // 
            this.com_jyw.FormattingEnabled = true;
            this.com_jyw.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.com_jyw.Location = new System.Drawing.Point(75, 124);
            this.com_jyw.Name = "com_jyw";
            this.com_jyw.Size = new System.Drawing.Size(95, 20);
            this.com_jyw.TabIndex = 12;
            // 
            // lbl_jyw
            // 
            this.lbl_jyw.AutoSize = true;
            this.lbl_jyw.Location = new System.Drawing.Point(15, 127);
            this.lbl_jyw.Name = "lbl_jyw";
            this.lbl_jyw.Size = new System.Drawing.Size(47, 12);
            this.lbl_jyw.TabIndex = 11;
            this.lbl_jyw.Text = "校验位:";
            // 
            // com_state
            // 
            this.com_state.AutoSize = true;
            this.com_state.Location = new System.Drawing.Point(46, 160);
            this.com_state.Name = "com_state";
            this.com_state.Size = new System.Drawing.Size(14, 13);
            this.com_state.TabIndex = 10;
            this.com_state.TabStop = true;
            this.com_state.UseVisualStyleBackColor = true;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(11, 160);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(35, 12);
            this.lbl_state.TabIndex = 9;
            this.lbl_state.Text = "状态:";
            // 
            // com_open
            // 
            this.com_open.Location = new System.Drawing.Point(76, 152);
            this.com_open.Name = "com_open";
            this.com_open.Size = new System.Drawing.Size(95, 29);
            this.com_open.TabIndex = 8;
            this.com_open.Text = "打开串口";
            this.com_open.UseVisualStyleBackColor = true;
            this.com_open.Click += new System.EventHandler(this.com_open_Click);
            // 
            // com_stop
            // 
            this.com_stop.FormattingEnabled = true;
            this.com_stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.com_stop.Location = new System.Drawing.Point(75, 98);
            this.com_stop.Name = "com_stop";
            this.com_stop.Size = new System.Drawing.Size(95, 20);
            this.com_stop.TabIndex = 7;
            // 
            // lbl_stop
            // 
            this.lbl_stop.AutoSize = true;
            this.lbl_stop.Location = new System.Drawing.Point(15, 101);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(47, 12);
            this.lbl_stop.TabIndex = 6;
            this.lbl_stop.Text = "停止位:";
            // 
            // com_data
            // 
            this.com_data.FormattingEnabled = true;
            this.com_data.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.com_data.Location = new System.Drawing.Point(75, 72);
            this.com_data.Name = "com_data";
            this.com_data.Size = new System.Drawing.Size(95, 20);
            this.com_data.TabIndex = 5;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(15, 75);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(47, 12);
            this.lbl_data.TabIndex = 4;
            this.lbl_data.Text = "数据位:";
            // 
            // com_bps
            // 
            this.com_bps.FormattingEnabled = true;
            this.com_bps.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.com_bps.Location = new System.Drawing.Point(75, 46);
            this.com_bps.Name = "com_bps";
            this.com_bps.Size = new System.Drawing.Size(95, 20);
            this.com_bps.TabIndex = 3;
            // 
            // lbl_bps
            // 
            this.lbl_bps.AutoSize = true;
            this.lbl_bps.Location = new System.Drawing.Point(15, 49);
            this.lbl_bps.Name = "lbl_bps";
            this.lbl_bps.Size = new System.Drawing.Size(47, 12);
            this.lbl_bps.TabIndex = 2;
            this.lbl_bps.Text = "波特率:";
            // 
            // com_port
            // 
            this.com_port.FormattingEnabled = true;
            this.com_port.Location = new System.Drawing.Point(75, 18);
            this.com_port.Name = "com_port";
            this.com_port.Size = new System.Drawing.Size(95, 20);
            this.com_port.TabIndex = 1;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(17, 21);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 12);
            this.lbl_port.TabIndex = 0;
            this.lbl_port.Text = "端口:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IsLine);
            this.groupBox2.Controls.Add(this.IsTime);
            this.groupBox2.Controls.Add(this.receive_FileSrc);
            this.groupBox2.Controls.Add(this.receive_file);
            this.groupBox2.Controls.Add(this.receive_save);
            this.groupBox2.Controls.Add(this.receive_clean);
            this.groupBox2.Controls.Add(this.receive_hex);
            this.groupBox2.Controls.Add(this.receive_ascii);
            this.groupBox2.Location = new System.Drawing.Point(8, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // IsLine
            // 
            this.IsLine.AutoSize = true;
            this.IsLine.Location = new System.Drawing.Point(16, 87);
            this.IsLine.Name = "IsLine";
            this.IsLine.Size = new System.Drawing.Size(72, 16);
            this.IsLine.TabIndex = 9;
            this.IsLine.Text = "是否换行";
            this.IsLine.UseVisualStyleBackColor = true;
            // 
            // IsTime
            // 
            this.IsTime.AutoSize = true;
            this.IsTime.Location = new System.Drawing.Point(17, 65);
            this.IsTime.Name = "IsTime";
            this.IsTime.Size = new System.Drawing.Size(96, 16);
            this.IsTime.TabIndex = 8;
            this.IsTime.Text = "是否显示时间";
            this.IsTime.UseVisualStyleBackColor = true;
            // 
            // receive_FileSrc
            // 
            this.receive_FileSrc.Location = new System.Drawing.Point(6, 138);
            this.receive_FileSrc.Name = "receive_FileSrc";
            this.receive_FileSrc.Size = new System.Drawing.Size(164, 21);
            this.receive_FileSrc.TabIndex = 7;
            // 
            // receive_file
            // 
            this.receive_file.Location = new System.Drawing.Point(95, 109);
            this.receive_file.Name = "receive_file";
            this.receive_file.Size = new System.Drawing.Size(75, 23);
            this.receive_file.TabIndex = 6;
            this.receive_file.Text = "文件路径";
            this.receive_file.UseVisualStyleBackColor = true;
            this.receive_file.Click += new System.EventHandler(this.receive_file_Click);
            // 
            // receive_save
            // 
            this.receive_save.AutoSize = true;
            this.receive_save.Location = new System.Drawing.Point(18, 43);
            this.receive_save.Name = "receive_save";
            this.receive_save.Size = new System.Drawing.Size(96, 16);
            this.receive_save.TabIndex = 5;
            this.receive_save.Text = "是否存储文件";
            this.receive_save.UseVisualStyleBackColor = true;
            // 
            // receive_clean
            // 
            this.receive_clean.Location = new System.Drawing.Point(6, 109);
            this.receive_clean.Name = "receive_clean";
            this.receive_clean.Size = new System.Drawing.Size(75, 23);
            this.receive_clean.TabIndex = 4;
            this.receive_clean.Text = "清空接收区";
            this.receive_clean.UseVisualStyleBackColor = true;
            this.receive_clean.Click += new System.EventHandler(this.receive_clean_Click);
            // 
            // receive_hex
            // 
            this.receive_hex.AutoSize = true;
            this.receive_hex.Location = new System.Drawing.Point(108, 21);
            this.receive_hex.Name = "receive_hex";
            this.receive_hex.Size = new System.Drawing.Size(41, 16);
            this.receive_hex.TabIndex = 1;
            this.receive_hex.TabStop = true;
            this.receive_hex.Text = "HEX";
            this.receive_hex.UseVisualStyleBackColor = true;
            this.receive_hex.CheckedChanged += new System.EventHandler(this.receive_hex_CheckedChanged);
            // 
            // receive_ascii
            // 
            this.receive_ascii.AutoSize = true;
            this.receive_ascii.Location = new System.Drawing.Point(17, 21);
            this.receive_ascii.Name = "receive_ascii";
            this.receive_ascii.Size = new System.Drawing.Size(53, 16);
            this.receive_ascii.TabIndex = 0;
            this.receive_ascii.TabStop = true;
            this.receive_ascii.Text = "ASCII";
            this.receive_ascii.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.send_clean);
            this.groupBox3.Controls.Add(this.send_file);
            this.groupBox3.Controls.Add(this.send_hex);
            this.groupBox3.Controls.Add(this.send_ascii);
            this.groupBox3.Location = new System.Drawing.Point(12, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // send_clean
            // 
            this.send_clean.Location = new System.Drawing.Point(6, 75);
            this.send_clean.Name = "send_clean";
            this.send_clean.Size = new System.Drawing.Size(75, 23);
            this.send_clean.TabIndex = 6;
            this.send_clean.Text = "清空发送区";
            this.send_clean.UseVisualStyleBackColor = true;
            this.send_clean.Click += new System.EventHandler(this.send_clean_Click);
            // 
            // send_file
            // 
            this.send_file.Location = new System.Drawing.Point(83, 75);
            this.send_file.Name = "send_file";
            this.send_file.Size = new System.Drawing.Size(91, 23);
            this.send_file.TabIndex = 5;
            this.send_file.Text = "选择发送文件";
            this.send_file.UseVisualStyleBackColor = true;
            this.send_file.Click += new System.EventHandler(this.send_file_Click);
            // 
            // send_hex
            // 
            this.send_hex.AutoSize = true;
            this.send_hex.Location = new System.Drawing.Point(115, 36);
            this.send_hex.Name = "send_hex";
            this.send_hex.Size = new System.Drawing.Size(41, 16);
            this.send_hex.TabIndex = 3;
            this.send_hex.TabStop = true;
            this.send_hex.Text = "HEX";
            this.send_hex.UseVisualStyleBackColor = true;
            this.send_hex.Click += new System.EventHandler(this.send_hex_Click);
            // 
            // send_ascii
            // 
            this.send_ascii.AutoSize = true;
            this.send_ascii.Location = new System.Drawing.Point(24, 36);
            this.send_ascii.Name = "send_ascii";
            this.send_ascii.Size = new System.Drawing.Size(53, 16);
            this.send_ascii.TabIndex = 2;
            this.send_ascii.TabStop = true;
            this.send_ascii.Text = "ASCII";
            this.send_ascii.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Controls.Add(this.bt_ReceiveData);
            this.groupBox4.Location = new System.Drawing.Point(196, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 389);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收日志";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(52, 504);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(293, 56);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // bt_ReceiveData
            // 
            this.bt_ReceiveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ReceiveData.Location = new System.Drawing.Point(3, 17);
            this.bt_ReceiveData.Name = "bt_ReceiveData";
            this.bt_ReceiveData.Size = new System.Drawing.Size(568, 369);
            this.bt_ReceiveData.TabIndex = 4;
            this.bt_ReceiveData.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_send);
            this.groupBox5.Controls.Add(this.bt_SendData);
            this.groupBox5.Location = new System.Drawing.Point(196, 407);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(574, 110);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据发送";
            // 
            // bt_send
            // 
            this.bt_send.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_send.Location = new System.Drawing.Point(482, 21);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(92, 77);
            this.bt_send.TabIndex = 1;
            this.bt_send.Text = "确定发送";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_SendData
            // 
            this.bt_SendData.Location = new System.Drawing.Point(6, 17);
            this.bt_SendData.Name = "bt_SendData";
            this.bt_SendData.Size = new System.Drawing.Size(469, 81);
            this.bt_SendData.TabIndex = 0;
            this.bt_SendData.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.send_num,
            this.num1,
            this.received_num,
            this.num2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // send_num
            // 
            this.send_num.Name = "send_num";
            this.send_num.Size = new System.Drawing.Size(68, 17);
            this.send_num.Text = "发字节数：";
            // 
            // num1
            // 
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(15, 17);
            this.num1.Text = "0";
            // 
            // received_num
            // 
            this.received_num.Name = "received_num";
            this.received_num.Size = new System.Drawing.Size(68, 17);
            this.received_num.Text = "接字节数：";
            // 
            // num2
            // 
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(15, 17);
            this.num2.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Comm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 546);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comm";
            this.Text = "串口通讯助手";
            this.Load += new System.EventHandler(this.Comm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox bt_ReceiveData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.RichTextBox bt_SendData;
        private System.Windows.Forms.RadioButton com_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Button com_open;
        private System.Windows.Forms.ComboBox com_stop;
        private System.Windows.Forms.Label lbl_stop;
        private System.Windows.Forms.ComboBox com_data;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.ComboBox com_bps;
        private System.Windows.Forms.Label lbl_bps;
        private System.Windows.Forms.ComboBox com_port;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox receive_FileSrc;
        private System.Windows.Forms.Button receive_file;
        private System.Windows.Forms.CheckBox receive_save;
        private System.Windows.Forms.Button receive_clean;
        private System.Windows.Forms.RadioButton receive_hex;
        private System.Windows.Forms.RadioButton receive_ascii;
        private System.Windows.Forms.Button send_clean;
        private System.Windows.Forms.Button send_file;
        private System.Windows.Forms.RadioButton send_hex;
        private System.Windows.Forms.RadioButton send_ascii;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel send_num;
        private System.Windows.Forms.ToolStripStatusLabel received_num;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox com_jyw;
        private System.Windows.Forms.Label lbl_jyw;
        private System.Windows.Forms.ToolStripStatusLabel num1;
        private System.Windows.Forms.ToolStripStatusLabel num2;
        private System.Windows.Forms.CheckBox IsLine;
        private System.Windows.Forms.CheckBox IsTime;
    }
}

