namespace SerialPortReadWinForm
{
    partial class MainWindo
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
            this.MainTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveConfigBtn = new System.Windows.Forms.Button();
            this.OpenConfigFileBtn = new System.Windows.Forms.Button();
            this.ConfigFilePath = new System.Windows.Forms.Label();
            this.gruopBox2 = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stopbitsCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databitsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbitsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buadRateCB = new System.Windows.Forms.ComboBox();
            this.portsListLabel = new System.Windows.Forms.Label();
            this.portsListCB = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TestConnBtn = new System.Windows.Forms.Button();
            this.dbNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbPwdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dbUsrNameTB = new System.Windows.Forms.TextBox();
            this.dbPortDB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dbServerAddressTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveToFileCheck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataRTB = new System.Windows.Forms.RichTextBox();
            this.openConfigFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gruopBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.SystemColors.Control;
            this.MainTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(106, 9);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(260, 16);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Serial Ports Read and Upload";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainTitle.Click += new System.EventHandler(this.MainTitle_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(460, 308);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gruopBox2);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(220, 308);
            this.splitContainer2.SplitterDistance = 85;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveConfigBtn);
            this.groupBox1.Controls.Add(this.OpenConfigFileBtn);
            this.groupBox1.Controls.Add(this.ConfigFilePath);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config File";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // saveConfigBtn
            // 
            this.saveConfigBtn.Location = new System.Drawing.Point(107, 46);
            this.saveConfigBtn.Name = "saveConfigBtn";
            this.saveConfigBtn.Size = new System.Drawing.Size(75, 23);
            this.saveConfigBtn.TabIndex = 2;
            this.saveConfigBtn.Text = "Save";
            this.saveConfigBtn.UseVisualStyleBackColor = true;
            this.saveConfigBtn.Click += new System.EventHandler(this.saveConfigBtn_Click);
            // 
            // OpenConfigFileBtn
            // 
            this.OpenConfigFileBtn.Location = new System.Drawing.Point(26, 46);
            this.OpenConfigFileBtn.Name = "OpenConfigFileBtn";
            this.OpenConfigFileBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenConfigFileBtn.TabIndex = 1;
            this.OpenConfigFileBtn.Text = "Open";
            this.OpenConfigFileBtn.UseVisualStyleBackColor = true;
            this.OpenConfigFileBtn.Click += new System.EventHandler(this.OpenConfigFileBtn_Click);
            // 
            // ConfigFilePath
            // 
            this.ConfigFilePath.AutoSize = true;
            this.ConfigFilePath.Location = new System.Drawing.Point(7, 17);
            this.ConfigFilePath.Name = "ConfigFilePath";
            this.ConfigFilePath.Size = new System.Drawing.Size(65, 12);
            this.ConfigFilePath.TabIndex = 0;
            this.ConfigFilePath.Text = "*FilePath*";
            // 
            // gruopBox2
            // 
            this.gruopBox2.Controls.Add(this.stopBtn);
            this.gruopBox2.Controls.Add(this.startBtn);
            this.gruopBox2.Controls.Add(this.label4);
            this.gruopBox2.Controls.Add(this.stopbitsCB);
            this.gruopBox2.Controls.Add(this.label3);
            this.gruopBox2.Controls.Add(this.databitsCB);
            this.gruopBox2.Controls.Add(this.label2);
            this.gruopBox2.Controls.Add(this.checkbitsCB);
            this.gruopBox2.Controls.Add(this.label1);
            this.gruopBox2.Controls.Add(this.buadRateCB);
            this.gruopBox2.Controls.Add(this.portsListLabel);
            this.gruopBox2.Controls.Add(this.portsListCB);
            this.gruopBox2.Location = new System.Drawing.Point(6, 9);
            this.gruopBox2.Name = "gruopBox2";
            this.gruopBox2.Size = new System.Drawing.Size(211, 204);
            this.gruopBox2.TabIndex = 0;
            this.gruopBox2.TabStop = false;
            this.gruopBox2.Text = "Serial Port";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(113, 172);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(90, 23);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "Close Port";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(6, 172);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(90, 23);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Open Port";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stopbits";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // stopbitsCB
            // 
            this.stopbitsCB.FormattingEnabled = true;
            this.stopbitsCB.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbitsCB.Location = new System.Drawing.Point(81, 145);
            this.stopbitsCB.Name = "stopbitsCB";
            this.stopbitsCB.Size = new System.Drawing.Size(121, 20);
            this.stopbitsCB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Databits";
            // 
            // databitsCB
            // 
            this.databitsCB.FormattingEnabled = true;
            this.databitsCB.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.databitsCB.Location = new System.Drawing.Point(81, 115);
            this.databitsCB.Name = "databitsCB";
            this.databitsCB.Size = new System.Drawing.Size(121, 20);
            this.databitsCB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Checkbits";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkbitsCB
            // 
            this.checkbitsCB.FormattingEnabled = true;
            this.checkbitsCB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.checkbitsCB.Location = new System.Drawing.Point(81, 85);
            this.checkbitsCB.Name = "checkbitsCB";
            this.checkbitsCB.Size = new System.Drawing.Size(121, 20);
            this.checkbitsCB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buad Rate";
            // 
            // buadRateCB
            // 
            this.buadRateCB.FormattingEnabled = true;
            this.buadRateCB.Items.AddRange(new object[] {
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
            "115200",
            "128000",
            "256000"});
            this.buadRateCB.Location = new System.Drawing.Point(81, 56);
            this.buadRateCB.Name = "buadRateCB";
            this.buadRateCB.Size = new System.Drawing.Size(121, 20);
            this.buadRateCB.TabIndex = 2;
            this.buadRateCB.SelectedIndexChanged += new System.EventHandler(this.buadRateCB_SelectedIndexChanged);
            // 
            // portsListLabel
            // 
            this.portsListLabel.AutoSize = true;
            this.portsListLabel.Location = new System.Drawing.Point(7, 28);
            this.portsListLabel.Name = "portsListLabel";
            this.portsListLabel.Size = new System.Drawing.Size(29, 12);
            this.portsListLabel.TabIndex = 1;
            this.portsListLabel.Text = "Port";
            this.portsListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // portsListCB
            // 
            this.portsListCB.FormattingEnabled = true;
            this.portsListCB.Location = new System.Drawing.Point(81, 26);
            this.portsListCB.Name = "portsListCB";
            this.portsListCB.Size = new System.Drawing.Size(121, 20);
            this.portsListCB.TabIndex = 0;
            this.portsListCB.SelectedIndexChanged += new System.EventHandler(this.portsListCB_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TestConnBtn);
            this.groupBox4.Controls.Add(this.dbNameTB);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dbPwdTB);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dbUsrNameTB);
            this.groupBox4.Controls.Add(this.dbPortDB);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dbServerAddressTB);
            this.groupBox4.Location = new System.Drawing.Point(6, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 204);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Configuration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 13;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TestConnBtn
            // 
            this.TestConnBtn.Location = new System.Drawing.Point(16, 172);
            this.TestConnBtn.Name = "TestConnBtn";
            this.TestConnBtn.Size = new System.Drawing.Size(75, 23);
            this.TestConnBtn.TabIndex = 12;
            this.TestConnBtn.Text = "Test";
            this.TestConnBtn.UseVisualStyleBackColor = true;
            this.TestConnBtn.Click += new System.EventHandler(this.TestConnBtn_Click);
            // 
            // dbNameTB
            // 
            this.dbNameTB.Location = new System.Drawing.Point(93, 139);
            this.dbNameTB.Name = "dbNameTB";
            this.dbNameTB.Size = new System.Drawing.Size(121, 21);
            this.dbNameTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "DB Name";
            // 
            // dbPwdTB
            // 
            this.dbPwdTB.Location = new System.Drawing.Point(93, 112);
            this.dbPwdTB.Name = "dbPwdTB";
            this.dbPwdTB.Size = new System.Drawing.Size(121, 21);
            this.dbPwdTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Username";
            // 
            // dbUsrNameTB
            // 
            this.dbUsrNameTB.Location = new System.Drawing.Point(93, 85);
            this.dbUsrNameTB.Name = "dbUsrNameTB";
            this.dbUsrNameTB.Size = new System.Drawing.Size(121, 21);
            this.dbUsrNameTB.TabIndex = 6;
            // 
            // dbPortDB
            // 
            this.dbPortDB.Location = new System.Drawing.Point(93, 58);
            this.dbPortDB.Name = "dbPortDB";
            this.dbPortDB.Size = new System.Drawing.Size(121, 21);
            this.dbPortDB.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Address";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dbServerAddressTB
            // 
            this.dbServerAddressTB.Location = new System.Drawing.Point(93, 31);
            this.dbServerAddressTB.Name = "dbServerAddressTB";
            this.dbServerAddressTB.Size = new System.Drawing.Size(121, 21);
            this.dbServerAddressTB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.saveToFileCheck);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Saving";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Upload to Database";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // saveToFileCheck
            // 
            this.saveToFileCheck.AutoSize = true;
            this.saveToFileCheck.Location = new System.Drawing.Point(20, 20);
            this.saveToFileCheck.Name = "saveToFileCheck";
            this.saveToFileCheck.Size = new System.Drawing.Size(96, 16);
            this.saveToFileCheck.TabIndex = 0;
            this.saveToFileCheck.Text = "Save to File";
            this.saveToFileCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataRTB);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 254);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data from Port";
            // 
            // dataRTB
            // 
            this.dataRTB.Location = new System.Drawing.Point(6, 20);
            this.dataRTB.Name = "dataRTB";
            this.dataRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.dataRTB.Size = new System.Drawing.Size(448, 224);
            this.dataRTB.TabIndex = 0;
            this.dataRTB.Text = "";
            this.dataRTB.TextChanged += new System.EventHandler(this.dataRTB_TextChanged);
            // 
            // openConfigFileDialog
            // 
            this.openConfigFileDialog.FileName = "config.ini";
            this.openConfigFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainWindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainTitle);
            this.Name = "MainWindo";
            this.Text = "Serial Port Read";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gruopBox2.ResumeLayout(false);
            this.gruopBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpenConfigFileBtn;
        private System.Windows.Forms.Label ConfigFilePath;
        private System.Windows.Forms.OpenFileDialog openConfigFileDialog;
        private System.Windows.Forms.GroupBox gruopBox2;
        private System.Windows.Forms.Label portsListLabel;
        private System.Windows.Forms.ComboBox portsListCB;
        private System.Windows.Forms.ComboBox buadRateCB;
        private System.Windows.Forms.ComboBox checkbitsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stopbitsCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox databitsCB;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox saveToFileCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox dataRTB;
        private System.Windows.Forms.Button saveConfigBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button TestConnBtn;
        private System.Windows.Forms.TextBox dbNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dbPwdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dbUsrNameTB;
        private System.Windows.Forms.TextBox dbPortDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dbServerAddressTB;
        private System.Windows.Forms.Label label10;
    }
}

