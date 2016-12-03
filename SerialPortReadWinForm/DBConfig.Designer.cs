namespace SerialPortReadWinForm
{
    partial class DBConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelDBCancelBtn = new System.Windows.Forms.Button();
            this.saveDBConfigBtn = new System.Windows.Forms.Button();
            this.TestConnBtn = new System.Windows.Forms.Button();
            this.dbNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbPwdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbUsrNameTB = new System.Windows.Forms.TextBox();
            this.dbPortDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbServerAddressTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelDBCancelBtn);
            this.groupBox1.Controls.Add(this.saveDBConfigBtn);
            this.groupBox1.Controls.Add(this.TestConnBtn);
            this.groupBox1.Controls.Add(this.dbNameTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dbPwdTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dbUsrNameTB);
            this.groupBox1.Controls.Add(this.dbPortDB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dbServerAddressTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Configuration";
            // 
            // cancelDBCancelBtn
            // 
            this.cancelDBCancelBtn.Location = new System.Drawing.Point(175, 202);
            this.cancelDBCancelBtn.Name = "cancelDBCancelBtn";
            this.cancelDBCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelDBCancelBtn.TabIndex = 14;
            this.cancelDBCancelBtn.Text = "Cancel";
            this.cancelDBCancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveDBConfigBtn
            // 
            this.saveDBConfigBtn.Location = new System.Drawing.Point(93, 202);
            this.saveDBConfigBtn.Name = "saveDBConfigBtn";
            this.saveDBConfigBtn.Size = new System.Drawing.Size(75, 23);
            this.saveDBConfigBtn.TabIndex = 13;
            this.saveDBConfigBtn.Text = "Save";
            this.saveDBConfigBtn.UseVisualStyleBackColor = true;
            // 
            // TestConnBtn
            // 
            this.TestConnBtn.Location = new System.Drawing.Point(11, 202);
            this.TestConnBtn.Name = "TestConnBtn";
            this.TestConnBtn.Size = new System.Drawing.Size(75, 23);
            this.TestConnBtn.TabIndex = 12;
            this.TestConnBtn.Text = "Test";
            this.TestConnBtn.UseVisualStyleBackColor = true;
            // 
            // dbNameTB
            // 
            this.dbNameTB.Location = new System.Drawing.Point(119, 173);
            this.dbNameTB.Name = "dbNameTB";
            this.dbNameTB.Size = new System.Drawing.Size(121, 21);
            this.dbNameTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Database Name";
            // 
            // dbPwdTB
            // 
            this.dbPwdTB.Location = new System.Drawing.Point(119, 137);
            this.dbPwdTB.Name = "dbPwdTB";
            this.dbPwdTB.Size = new System.Drawing.Size(121, 21);
            this.dbPwdTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // dbUsrNameTB
            // 
            this.dbUsrNameTB.Location = new System.Drawing.Point(119, 104);
            this.dbUsrNameTB.Name = "dbUsrNameTB";
            this.dbUsrNameTB.Size = new System.Drawing.Size(121, 21);
            this.dbUsrNameTB.TabIndex = 6;
            // 
            // dbPortDB
            // 
            this.dbPortDB.Location = new System.Drawing.Point(119, 68);
            this.dbPortDB.Name = "dbPortDB";
            this.dbPortDB.Size = new System.Drawing.Size(121, 21);
            this.dbPortDB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Address";
            // 
            // dbServerAddressTB
            // 
            this.dbServerAddressTB.Location = new System.Drawing.Point(119, 31);
            this.dbServerAddressTB.Name = "dbServerAddressTB";
            this.dbServerAddressTB.Size = new System.Drawing.Size(121, 21);
            this.dbServerAddressTB.TabIndex = 2;
            // 
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "DBConfig";
            this.Text = "DBConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dbPortDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbServerAddressTB;
        private System.Windows.Forms.Button cancelDBCancelBtn;
        private System.Windows.Forms.Button saveDBConfigBtn;
        private System.Windows.Forms.Button TestConnBtn;
        private System.Windows.Forms.TextBox dbNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dbPwdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbUsrNameTB;
    }
}