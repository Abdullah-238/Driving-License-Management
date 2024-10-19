namespace DVLD2
{
    partial class frmReplaceForLostOrDemage
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
            this.llShowLicneseHistory = new System.Windows.Forms.LinkLabel();
            this.lbRenewLicenseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbApplicationFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbRenewLicenseApp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titlte = new System.Windows.Forms.Label();
            this.btIssue = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ucLicenseWithFilter1 = new DVLD2.Licenses.ucLicenseWithFilter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowLicneseHistory
            // 
            this.llShowLicneseHistory.AutoSize = true;
            this.llShowLicneseHistory.Enabled = false;
            this.llShowLicneseHistory.Location = new System.Drawing.Point(24, 718);
            this.llShowLicneseHistory.Name = "llShowLicneseHistory";
            this.llShowLicneseHistory.Size = new System.Drawing.Size(137, 17);
            this.llShowLicneseHistory.TabIndex = 63;
            this.llShowLicneseHistory.TabStop = true;
            this.llShowLicneseHistory.Text = "Show License History";
            this.llShowLicneseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicneseHistory_LinkClicked_1);
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
            this.lbApplicationFee.Location = new System.Drawing.Point(205, 108);
            this.lbApplicationFee.Name = "lbApplicationFee";
            this.lbApplicationFee.Size = new System.Drawing.Size(41, 23);
            this.lbApplicationFee.TabIndex = 29;
            this.lbApplicationFee.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Application Fee :";
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
            this.lbCreatedBy.Location = new System.Drawing.Point(586, 104);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(41, 23);
            this.lbCreatedBy.TabIndex = 25;
            this.lbCreatedBy.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "Created By :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRenewLicenseID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbApplicationFee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbRenewLicenseApp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 160);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Basic Info ";
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
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "L-R-L.App.ID:";
            // 
            // Titlte
            // 
            this.Titlte.AutoSize = true;
            this.Titlte.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlte.Location = new System.Drawing.Point(161, 9);
            this.Titlte.Name = "Titlte";
            this.Titlte.Size = new System.Drawing.Size(559, 50);
            this.Titlte.TabIndex = 61;
            this.Titlte.Text = "Replace for Lost or Demage License ";
            // 
            // btIssue
            // 
            this.btIssue.Enabled = false;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIssue.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIssue.Image = global::DVLD2.Properties.Resources.IssueDrivingLicense_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(806, 710);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(110, 35);
            this.btIssue.TabIndex = 60;
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
            this.btClose.Location = new System.Drawing.Point(690, 710);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 59;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(180, 718);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(118, 17);
            this.llShowLicenseInfo.TabIndex = 64;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked_1);
            // 
            // ucLicenseWithFilter1
            // 
            this.ucLicenseWithFilter1.Location = new System.Drawing.Point(17, 62);
            this.ucLicenseWithFilter1.Name = "ucLicenseWithFilter1";
            this.ucLicenseWithFilter1.Size = new System.Drawing.Size(899, 476);
            this.ucLicenseWithFilter1.TabIndex = 58;
            this.ucLicenseWithFilter1.OnLicenseSelected += new System.Action<int>(this.ucLicenseWithFilter1_OnLicenseSelected_1);
            // 
            // frmReplaceForLostOrDemage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 755);
            this.Controls.Add(this.llShowLicneseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titlte);
            this.Controls.Add(this.ucLicenseWithFilter1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.llShowLicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReplaceForLostOrDemage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReplaceForLostOrDemage";
            this.Load += new System.EventHandler(this.frmReplaceForLostOrDemage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llShowLicneseHistory;
        private System.Windows.Forms.Label lbRenewLicenseID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbApplicationFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbRenewLicenseApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titlte;
        private Licenses.ucLicenseWithFilter ucLicenseWithFilter1;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
    }
}