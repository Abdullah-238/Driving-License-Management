namespace DVLD2
{
    partial class frmRealeaseLicense
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
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbApplicationFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbFineFee = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDetainedDate = new System.Windows.Forms.Label();
            this.lbDetainedID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titlte = new System.Windows.Forms.Label();
            this.ucLicenseWithFilter1 = new DVLD2.Licenses.ucLicenseWithFilter();
            this.btIssue = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowLicneseHistory
            // 
            this.llShowLicneseHistory.AutoSize = true;
            this.llShowLicneseHistory.Enabled = false;
            this.llShowLicneseHistory.Location = new System.Drawing.Point(7, 737);
            this.llShowLicneseHistory.Name = "llShowLicneseHistory";
            this.llShowLicneseHistory.Size = new System.Drawing.Size(137, 17);
            this.llShowLicneseHistory.TabIndex = 63;
            this.llShowLicneseHistory.TabStop = true;
            this.llShowLicneseHistory.Text = "Show License History";
            this.llShowLicneseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicneseHistory_LinkClicked);
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(586, 30);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(41, 23);
            this.lbLicenseID.TabIndex = 31;
            this.lbLicenseID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "License ID :";
            // 
            // lbApplicationFee
            // 
            this.lbApplicationFee.AutoSize = true;
            this.lbApplicationFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFee.Location = new System.Drawing.Point(205, 105);
            this.lbApplicationFee.Name = "lbApplicationFee";
            this.lbApplicationFee.Size = new System.Drawing.Size(41, 23);
            this.lbApplicationFee.TabIndex = 29;
            this.lbApplicationFee.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Application Fee :";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCreatedBy.Location = new System.Drawing.Point(586, 66);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(41, 23);
            this.lbCreatedBy.TabIndex = 25;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbFineFee
            // 
            this.lbFineFee.AutoSize = true;
            this.lbFineFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbFineFee.Location = new System.Drawing.Point(586, 105);
            this.lbFineFee.Name = "lbFineFee";
            this.lbFineFee.Size = new System.Drawing.Size(41, 23);
            this.lbFineFee.TabIndex = 23;
            this.lbFineFee.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "Created By :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fine Fee :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbApplicationID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbTotalFee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbLicenseID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbApplicationFee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbFineFee);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbDetainedDate);
            this.groupBox1.Controls.Add(this.lbDetainedID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 188);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Basic Info ";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbApplicationID.Location = new System.Drawing.Point(586, 142);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(41, 23);
            this.lbApplicationID.TabIndex = 35;
            this.lbApplicationID.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Application ID :";
            // 
            // lbTotalFee
            // 
            this.lbTotalFee.AutoSize = true;
            this.lbTotalFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTotalFee.Location = new System.Drawing.Point(205, 145);
            this.lbTotalFee.Name = "lbTotalFee";
            this.lbTotalFee.Size = new System.Drawing.Size(41, 23);
            this.lbTotalFee.TabIndex = 33;
            this.lbTotalFee.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Total Fee :";
            // 
            // lbDetainedDate
            // 
            this.lbDetainedDate.AutoSize = true;
            this.lbDetainedDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedDate.Location = new System.Drawing.Point(205, 67);
            this.lbDetainedDate.Name = "lbDetainedDate";
            this.lbDetainedDate.Size = new System.Drawing.Size(41, 23);
            this.lbDetainedDate.TabIndex = 16;
            this.lbDetainedDate.Text = "[???]";
            // 
            // lbDetainedID
            // 
            this.lbDetainedID.AutoSize = true;
            this.lbDetainedID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedID.Location = new System.Drawing.Point(205, 26);
            this.lbDetainedID.Name = "lbDetainedID";
            this.lbDetainedID.Size = new System.Drawing.Size(41, 23);
            this.lbDetainedID.TabIndex = 15;
            this.lbDetainedID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Detained Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detained ID :";
            // 
            // Titlte
            // 
            this.Titlte.AutoSize = true;
            this.Titlte.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlte.Location = new System.Drawing.Point(319, 9);
            this.Titlte.Name = "Titlte";
            this.Titlte.Size = new System.Drawing.Size(265, 50);
            this.Titlte.TabIndex = 61;
            this.Titlte.Text = "License Release ";
            // 
            // ucLicenseWithFilter1
            // 
            this.ucLicenseWithFilter1.Location = new System.Drawing.Point(0, 53);
            this.ucLicenseWithFilter1.Name = "ucLicenseWithFilter1";
            this.ucLicenseWithFilter1.Size = new System.Drawing.Size(899, 476);
            this.ucLicenseWithFilter1.TabIndex = 58;
            this.ucLicenseWithFilter1.OnLicenseSelected += new System.Action<int>(this.ucLicenseWithFilter1_OnLicenseSelected);
            this.ucLicenseWithFilter1.Load += new System.EventHandler(this.ucLicenseWithFilter1_Load);
            // 
            // btIssue
            // 
            this.btIssue.Enabled = false;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIssue.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIssue.Image = global::DVLD2.Properties.Resources.Release_Detained_License_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(757, 729);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(142, 35);
            this.btIssue.TabIndex = 60;
            this.btIssue.Text = "Realease";
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
            this.btClose.Location = new System.Drawing.Point(641, 729);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 59;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(163, 737);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(118, 17);
            this.llShowLicenseInfo.TabIndex = 64;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // frmRealeaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 797);
            this.Controls.Add(this.llShowLicneseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titlte);
            this.Controls.Add(this.ucLicenseWithFilter1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.llShowLicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRealeaseLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainedLicense";
            this.Load += new System.EventHandler(this.frmRealeaseLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llShowLicneseHistory;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbApplicationFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbFineFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDetainedDate;
        private System.Windows.Forms.Label lbDetainedID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titlte;
        private Licenses.ucLicenseWithFilter ucLicenseWithFilter1;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalFee;
        private System.Windows.Forms.Label label4;
    }
}