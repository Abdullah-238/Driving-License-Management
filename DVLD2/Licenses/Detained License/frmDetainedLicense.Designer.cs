namespace DVLD2.Licenses.Detained_License
{
    partial class frmDetainedLicense
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
            this.label9 = new System.Windows.Forms.Label();
            this.lbDetainedDate = new System.Windows.Forms.Label();
            this.lbDetainedID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.Titlte = new System.Windows.Forms.Label();
            this.ucLicenseWithFilter1 = new DVLD2.Licenses.ucLicenseWithFilter();
            this.btIssue = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowLicneseHistory
            // 
            this.llShowLicneseHistory.AutoSize = true;
            this.llShowLicneseHistory.Enabled = false;
            this.llShowLicneseHistory.Location = new System.Drawing.Point(11, 701);
            this.llShowLicneseHistory.Name = "llShowLicneseHistory";
            this.llShowLicneseHistory.Size = new System.Drawing.Size(137, 17);
            this.llShowLicneseHistory.TabIndex = 70;
            this.llShowLicneseHistory.TabStop = true;
            this.llShowLicneseHistory.Text = "Show License History";
            this.llShowLicneseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicneseHistory_LinkClicked);
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
            // lbDetainedDate
            // 
            this.lbDetainedDate.AutoSize = true;
            this.lbDetainedDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedDate.Location = new System.Drawing.Point(205, 66);
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
            this.label2.Location = new System.Drawing.Point(42, 61);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbLicenseID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbDetainedDate);
            this.groupBox1.Controls.Add(this.lbDetainedID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 149);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "0";
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
            this.label8.Location = new System.Drawing.Point(465, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "License ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fee :";
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
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(677, 693);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 66;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Titlte
            // 
            this.Titlte.AutoSize = true;
            this.Titlte.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlte.Location = new System.Drawing.Point(302, 9);
            this.Titlte.Name = "Titlte";
            this.Titlte.Size = new System.Drawing.Size(267, 50);
            this.Titlte.TabIndex = 68;
            this.Titlte.Text = "DetainedLicense";
            // 
            // ucLicenseWithFilter1
            // 
            this.ucLicenseWithFilter1.Location = new System.Drawing.Point(-1, 56);
            this.ucLicenseWithFilter1.Name = "ucLicenseWithFilter1";
            this.ucLicenseWithFilter1.Size = new System.Drawing.Size(899, 476);
            this.ucLicenseWithFilter1.TabIndex = 65;
            this.ucLicenseWithFilter1.OnLicenseSelected += new System.Action<int>(this.ucLicenseWithFilter1_OnLicenseSelected);
            // 
            // btIssue
            // 
            this.btIssue.Enabled = false;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIssue.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIssue.Image = global::DVLD2.Properties.Resources.Detain_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(793, 693);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(110, 35);
            this.btIssue.TabIndex = 67;
            this.btIssue.Text = "Detain";
            this.btIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIssue.UseVisualStyleBackColor = true;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(167, 701);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(118, 17);
            this.llShowLicenseInfo.TabIndex = 71;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // frmDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 756);
            this.Controls.Add(this.llShowLicneseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.Titlte);
            this.Controls.Add(this.ucLicenseWithFilter1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.llShowLicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainedLicense";
            this.Load += new System.EventHandler(this.frmDetainedLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llShowLicneseHistory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDetainedDate;
        private System.Windows.Forms.Label lbDetainedID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label Titlte;
        private ucLicenseWithFilter ucLicenseWithFilter1;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
    }
}