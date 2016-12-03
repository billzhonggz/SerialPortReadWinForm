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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbConfigLabel = new System.Windows.Forms.Label();
            this.DBConfigBtn = new System.Windows.Forms.Button();
            this.saveFilePath = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveDataToFile = new System.Windows.Forms.Button();
            this.saveToFileCheck = new System.Windows.Forms.CheckBox();
            this.gruopBox2 = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stopbitsCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databitsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buadRateCB = new System.Windows.Forms.ComboBox();
            this.portsListLabel = new System.Windows.Forms.Label();
            this.portsListCB = new System.Windows.Forms.ComboBox();
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
            this.groupBox2.SuspendLayout();
            this.gruopBox2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(460, 418);
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.gruopBox2);
            this.splitContainer2.Size = new System.Drawing.Size(220, 418);
            this.splitContainer2.SplitterDistance = 71;
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
            this.groupBox1.Size = new System.Drawing.Size(214, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config File";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // saveConfigBtn
            // 
            this.saveConfigBtn.Location = new System.Drawing.Point(107, 36);
            this.saveConfigBtn.Name = "saveConfigBtn";
            this.saveConfigBtn.Size = new System.Drawing.Size(75, 23);
            this.saveConfigBtn.TabIndex = 2;
            this.saveConfigBtn.Text = "Save";
            this.saveConfigBtn.UseVisualStyleBackColor = true;
            // 
            // OpenConfigFileBtn
            // 
            this.OpenConfigFileBtn.Location = new System.Drawing.Point(26, 36);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dbConfigLabel);
            this.groupBox2.Controls.Add(this.DBConfigBtn);
            this.groupBox2.Controls.Add(this.saveFilePath);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.saveDataToFile);
            this.groupBox2.Controls.Add(this.saveToFileCheck);
            this.groupBox2.Location = new System.Drawing.Point(3, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Saving";
            // 
            // dbConfigLabel
            // 
            this.dbConfigLabel.AutoSize = true;
            this.dbConfigLabel.Location = new System.Drawing.Point(25, 115);
            this.dbConfigLabel.Name = "dbConfigLabel";
            this.dbConfigLabel.Size = new System.Drawing.Size(65, 12);
            this.dbConfigLabel.TabIndex = 5;
            this.dbConfigLabel.Text = "*DBConfig*";
            // 
            // DBConfigBtn
            // 
            this.DBConfigBtn.Location = new System.Drawing.Point(49, 86);
            this.DBConfigBtn.Name = "DBConfigBtn";
            this.DBConfigBtn.Size = new System.Drawing.Size(159, 23);
            this.DBConfigBtn.TabIndex = 4;
            this.DBConfigBtn.Text = "Database Configuration";
            this.DBConfigBtn.UseVisualStyleBackColor = true;
            // 
            // saveFilePath
            // 
            this.saveFilePath.AutoSize = true;
            this.saveFilePath.Location = new System.Drawing.Point(25, 42);
            this.saveFilePath.Name = "saveFilePath";
            this.saveFilePath.Size = new System.Drawing.Size(65, 12);
            this.saveFilePath.TabIndex = 3;
            this.saveFilePath.Text = "*FilePath*";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Upload to Database";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // saveDataToFile
            // 
            this.saveDataToFile.Location = new System.Drawing.Point(132, 17);
            this.saveDataToFile.Name = "saveDataToFile";
            this.saveDataToFile.Size = new System.Drawing.Size(75, 23);
            this.saveDataToFile.TabIndex = 1;
            this.saveDataToFile.Text = "Browse";
            this.saveDataToFile.UseVisualStyleBackColor = true;
            this.saveDataToFile.Click += new System.EventHandler(this.saveDataToFile_Click);
            // 
            // saveToFileCheck
            // 
            this.saveToFileCheck.AutoSize = true;
            this.saveToFileCheck.Location = new System.Drawing.Point(7, 21);
            this.saveToFileCheck.Name = "saveToFileCheck";
            this.saveToFileCheck.Size = new System.Drawing.Size(96, 16);
            this.saveToFileCheck.TabIndex = 0;
            this.saveToFileCheck.Text = "Save to File";
            this.saveToFileCheck.UseVisualStyleBackColor = true;
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
            this.gruopBox2.Controls.Add(this.comboBox2);
            this.gruopBox2.Controls.Add(this.label1);
            this.gruopBox2.Controls.Add(this.buadRateCB);
            this.gruopBox2.Controls.Add(this.portsListLabel);
            this.gruopBox2.Controls.Add(this.portsListCB);
            this.gruopBox2.Location = new System.Drawing.Point(3, 3);
            this.gruopBox2.Name = "gruopBox2";
            this.gruopBox2.Size = new System.Drawing.Size(214, 192);
            this.gruopBox2.TabIndex = 0;
            this.gruopBox2.TabStop = false;
            this.gruopBox2.Text = "Serial Port";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(118, 157);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(90, 23);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "Close Port";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(11, 157);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(90, 23);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Open Port";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 132);
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
            "1 bit",
            "1.5 bits",
            "2 bits"});
            this.stopbitsCB.Location = new System.Drawing.Point(87, 128);
            this.stopbitsCB.Name = "stopbitsCB";
            this.stopbitsCB.Size = new System.Drawing.Size(121, 20);
            this.stopbitsCB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Databits";
            // 
            // databitsCB
            // 
            this.databitsCB.FormattingEnabled = true;
            this.databitsCB.Items.AddRange(new object[] {
            "4 bits",
            "5 bits",
            "6 bits",
            "7 bits",
            "8 bits"});
            this.databitsCB.Location = new System.Drawing.Point(87, 101);
            this.databitsCB.Name = "databitsCB";
            this.databitsCB.Size = new System.Drawing.Size(121, 20);
            this.databitsCB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Checkbits";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Odd Check",
            "Even Check",
            "Check by 1",
            "Check by 0"});
            this.comboBox2.Location = new System.Drawing.Point(87, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
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
            this.buadRateCB.Location = new System.Drawing.Point(87, 47);
            this.buadRateCB.Name = "buadRateCB";
            this.buadRateCB.Size = new System.Drawing.Size(121, 20);
            this.buadRateCB.TabIndex = 2;
            this.buadRateCB.SelectedIndexChanged += new System.EventHandler(this.buadRateCB_SelectedIndexChanged);
            // 
            // portsListLabel
            // 
            this.portsListLabel.AutoSize = true;
            this.portsListLabel.Location = new System.Drawing.Point(7, 23);
            this.portsListLabel.Name = "portsListLabel";
            this.portsListLabel.Size = new System.Drawing.Size(29, 12);
            this.portsListLabel.TabIndex = 1;
            this.portsListLabel.Text = "Port";
            this.portsListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // portsListCB
            // 
            this.portsListCB.FormattingEnabled = true;
            this.portsListCB.Location = new System.Drawing.Point(87, 20);
            this.portsListCB.Name = "portsListCB";
            this.portsListCB.Size = new System.Drawing.Size(121, 20);
            this.portsListCB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataRTB);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 411);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data from Port";
            // 
            // dataRTB
            // 
            this.dataRTB.Location = new System.Drawing.Point(6, 20);
            this.dataRTB.Name = "dataRTB";
            this.dataRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.dataRTB.Size = new System.Drawing.Size(217, 385);
            this.dataRTB.TabIndex = 0;
            this.dataRTB.Text = "";
            // 
            // openConfigFileDialog
            // 
            this.openConfigFileDialog.FileName = "config.xml";
            this.openConfigFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainWindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gruopBox2.ResumeLayout(false);
            this.gruopBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stopbitsCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox databitsCB;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveDataToFile;
        private System.Windows.Forms.CheckBox saveToFileCheck;
        private System.Windows.Forms.Label dbConfigLabel;
        private System.Windows.Forms.Button DBConfigBtn;
        private System.Windows.Forms.Label saveFilePath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox dataRTB;
        private System.Windows.Forms.Button saveConfigBtn;
    }
}

