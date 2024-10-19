namespace DVLD2.LocalDriverApplication
{
    partial class frmAddNewLocalApplication
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.btNext = new System.Windows.Forms.Button();
            this.ucUserInfoWithFilter1 = new DVLD2.Users.ucPersonInfoWithFilter();
            this.tbApplicationnfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClassess = new System.Windows.Forms.ComboBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbApplicationFee = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbDriverLocalApplication = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbApplicationnfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbPersonInfo);
            this.tabControl.Controls.Add(this.tbApplicationnfo);
            this.tabControl.Location = new System.Drawing.Point(12, 106);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(837, 514);
            this.tabControl.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.btNext);
            this.tbPersonInfo.Controls.Add(this.ucUserInfoWithFilter1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(829, 485);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Personal Information";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNext.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Image = global::DVLD2.Properties.Resources.Next_32;
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNext.Location = new System.Drawing.Point(719, 434);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(95, 35);
            this.btNext.TabIndex = 9;
            this.btNext.Text = "Next";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // ucUserInfoWithFilter1
            // 
            this.ucUserInfoWithFilter1.Location = new System.Drawing.Point(10, 16);
            this.ucUserInfoWithFilter1.Name = "ucUserInfoWithFilter1";
            this.ucUserInfoWithFilter1.Size = new System.Drawing.Size(804, 412);
            this.ucUserInfoWithFilter1.TabIndex = 0;
            this.ucUserInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ucUserInfoWithFilter1_OnPersonSelected);
            // 
            // tbApplicationnfo
            // 
            this.tbApplicationnfo.Controls.Add(this.cbLicenseClassess);
            this.tbApplicationnfo.Controls.Add(this.lbCreatedBy);
            this.tbApplicationnfo.Controls.Add(this.lbApplicationFee);
            this.tbApplicationnfo.Controls.Add(this.lbApplicationDate);
            this.tbApplicationnfo.Controls.Add(this.lbDriverLocalApplication);
            this.tbApplicationnfo.Controls.Add(this.label5);
            this.tbApplicationnfo.Controls.Add(this.label4);
            this.tbApplicationnfo.Controls.Add(this.label3);
            this.tbApplicationnfo.Controls.Add(this.label2);
            this.tbApplicationnfo.Controls.Add(this.label1);
            this.tbApplicationnfo.Location = new System.Drawing.Point(4, 25);
            this.tbApplicationnfo.Name = "tbApplicationnfo";
            this.tbApplicationnfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbApplicationnfo.Size = new System.Drawing.Size(829, 485);
            this.tbApplicationnfo.TabIndex = 1;
            this.tbApplicationnfo.Text = "Application Info";
            this.tbApplicationnfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClassess
            // 
            this.cbLicenseClassess.FormattingEnabled = true;
            this.cbLicenseClassess.Location = new System.Drawing.Point(309, 194);
            this.cbLicenseClassess.Name = "cbLicenseClassess";
            this.cbLicenseClassess.Size = new System.Drawing.Size(205, 24);
            this.cbLicenseClassess.TabIndex = 9;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(304, 272);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(61, 30);
            this.lbCreatedBy.TabIndex = 8;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbApplicationFee
            // 
            this.lbApplicationFee.AutoSize = true;
            this.lbApplicationFee.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFee.Location = new System.Drawing.Point(304, 231);
            this.lbApplicationFee.Name = "lbApplicationFee";
            this.lbApplicationFee.Size = new System.Drawing.Size(61, 30);
            this.lbApplicationFee.TabIndex = 7;
            this.lbApplicationFee.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(304, 149);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(61, 30);
            this.lbApplicationDate.TabIndex = 6;
            this.lbApplicationDate.Text = "[???]";
            // 
            // lbDriverLocalApplication
            // 
            this.lbDriverLocalApplication.AutoSize = true;
            this.lbDriverLocalApplication.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriverLocalApplication.Location = new System.Drawing.Point(304, 108);
            this.lbDriverLocalApplication.Name = "lbDriverLocalApplication";
            this.lbDriverLocalApplication.Size = new System.Drawing.Size(61, 30);
            this.lbDriverLocalApplication.TabIndex = 5;
            this.lbDriverLocalApplication.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Fee :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Class :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.Application :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitle.Location = new System.Drawing.Point(199, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(447, 50);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "New Local Driver Application";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(620, 636);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::DVLD2.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(736, 636);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 35);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmAddNewLocalApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 692);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddNewLocalApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewLocalApplication";
            this.Load += new System.EventHandler(this.frmAddNewLocalApplication_Load);
            this.tabControl.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbApplicationnfo.ResumeLayout(false);
            this.tbApplicationnfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbApplicationnfo;
        private System.Windows.Forms.Label lbTitle;
        private Users.ucPersonInfoWithFilter ucUserInfoWithFilter1;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbLicenseClassess;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbApplicationFee;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbDriverLocalApplication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}