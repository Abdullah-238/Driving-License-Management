namespace DVLD2
{
    partial class frmRenewLicenseDriver
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
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ucLicenseWithFilter1 = new DVLD2.Licenses.ucLicenseWithFilter();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbTotalFee = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.btIssue = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbLicenseFee = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llShowLicneseHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRenewLicenseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbApplicationFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRenewLicenseApp = new System.Windows.Forms.Label();
            this.Titlte = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(169, 909);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(118, 17);
            this.llShowLicenseInfo.TabIndex = 57;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // ucLicenseWithFilter1
            // 
            this.ucLicenseWithFilter1.Location = new System.Drawing.Point(2, 62);
            this.ucLicenseWithFilter1.Name = "ucLicenseWithFilter1";
            this.ucLicenseWithFilter1.Size = new System.Drawing.Size(899, 476);
            this.ucLicenseWithFilter1.TabIndex = 51;
            this.ucLicenseWithFilter1.OnLicenseSelected += new System.Action<int>(this.ucLicenseWithFilter1_OnLicenseSelected);
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(586, 64);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(41, 23);
            this.lbOldLicenseID.TabIndex = 27;
            this.lbOldLicenseID.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "OldLicenseID :";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCreatedBy.Location = new System.Drawing.Point(586, 142);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(41, 23);
            this.lbCreatedBy.TabIndex = 25;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbExpirationDate.Location = new System.Drawing.Point(586, 101);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(41, 23);
            this.lbExpirationDate.TabIndex = 24;
            this.lbExpirationDate.Text = "[???]";
            // 
            // lbTotalFee
            // 
            this.lbTotalFee.AutoSize = true;
            this.lbTotalFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTotalFee.Location = new System.Drawing.Point(586, 181);
            this.lbTotalFee.Name = "lbTotalFee";
            this.lbTotalFee.Size = new System.Drawing.Size(41, 23);
            this.lbTotalFee.TabIndex = 23;
            this.lbTotalFee.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "Created By :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 30);
            this.label10.TabIndex = 21;
            this.label10.Text = "Expiration Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total Fee :";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(205, 108);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(41, 23);
            this.lbIssueDate.TabIndex = 19;
            this.lbIssueDate.Text = "[???]";
            // 
            // btIssue
            // 
            this.btIssue.Enabled = false;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIssue.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIssue.Image = global::DVLD2.Properties.Resources.International_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(795, 901);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(110, 35);
            this.btIssue.TabIndex = 53;
            this.btIssue.Text = "Issue";
            this.btIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIssue.UseVisualStyleBackColor = true;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(679, 901);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 52;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // lbLicenseFee
            // 
            this.lbLicenseFee.AutoSize = true;
            this.lbLicenseFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFee.Location = new System.Drawing.Point(205, 149);
            this.lbLicenseFee.Name = "lbLicenseFee";
            this.lbLicenseFee.Size = new System.Drawing.Size(41, 23);
            this.lbLicenseFee.TabIndex = 17;
            this.lbLicenseFee.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(205, 67);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(41, 23);
            this.lbApplicationDate.TabIndex = 16;
            this.lbApplicationDate.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "License Fee :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Application Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "R-L.App.ID:";
            // 
            // llShowLicneseHistory
            // 
            this.llShowLicneseHistory.AutoSize = true;
            this.llShowLicneseHistory.Enabled = false;
            this.llShowLicneseHistory.Location = new System.Drawing.Point(13, 909);
            this.llShowLicneseHistory.Name = "llShowLicneseHistory";
            this.llShowLicneseHistory.Size = new System.Drawing.Size(137, 17);
            this.llShowLicneseHistory.TabIndex = 56;
            this.llShowLicneseHistory.TabStop = true;
            this.llShowLicneseHistory.Text = "Show License History";
            this.llShowLicneseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicneseHistory_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txNote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbRenewLicenseID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbApplicationFee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.lbTotalFee);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.lbLicenseFee);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbRenewLicenseApp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 351);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Basic Info ";
            // 
            // txNote
            // 
            this.txNote.Location = new System.Drawing.Point(205, 231);
            this.txNote.Multiline = true;
            this.txNote.Name = "txNote";
            this.txNote.Size = new System.Drawing.Size(631, 101);
            this.txNote.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Note :";
            // 
            // lbRenewLicenseID
            // 
            this.lbRenewLicenseID.AutoSize = true;
            this.lbRenewLicenseID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewLicenseID.Location = new System.Drawing.Point(586, 30);
            this.lbRenewLicenseID.Name = "lbRenewLicenseID";
            this.lbRenewLicenseID.Size = new System.Drawing.Size(41, 23);
            this.lbRenewLicenseID.TabIndex = 31;
            this.lbRenewLicenseID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "Renew.lic.ID:";
            // 
            // lbApplicationFee
            // 
            this.lbApplicationFee.AutoSize = true;
            this.lbApplicationFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFee.Location = new System.Drawing.Point(205, 189);
            this.lbApplicationFee.Name = "lbApplicationFee";
            this.lbApplicationFee.Size = new System.Drawing.Size(41, 23);
            this.lbApplicationFee.TabIndex = 29;
            this.lbApplicationFee.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Application Fee :";
            // 
            // lbRenewLicenseApp
            // 
            this.lbRenewLicenseApp.AutoSize = true;
            this.lbRenewLicenseApp.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewLicenseApp.Location = new System.Drawing.Point(205, 26);
            this.lbRenewLicenseApp.Name = "lbRenewLicenseApp";
            this.lbRenewLicenseApp.Size = new System.Drawing.Size(41, 23);
            this.lbRenewLicenseApp.TabIndex = 15;
            this.lbRenewLicenseApp.Text = "[???]";
            // 
            // Titlte
            // 
            this.Titlte.AutoSize = true;
            this.Titlte.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlte.Location = new System.Drawing.Point(191, 26);
            this.Titlte.Name = "Titlte";
            this.Titlte.Size = new System.Drawing.Size(533, 50);
            this.Titlte.TabIndex = 54;
            this.Titlte.Text = "Re-New License Driver Application";
            // 
            // frmRenewLicenseDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 955);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.ucLicenseWithFilter1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.llShowLicneseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titlte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRenewLicenseDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewLicenseDriver";
            this.Load += new System.EventHandler(this.frmRenewLicenseDriver_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private Licenses.ucLicenseWithFilter ucLicenseWithFilter1;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label lbTotalFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbLicenseFee;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llShowLicneseHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRenewLicenseApp;
        private System.Windows.Forms.Label Titlte;
        private System.Windows.Forms.Label lbApplicationFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbRenewLicenseID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNote;
        private System.Windows.Forms.Label label5;
    }
}