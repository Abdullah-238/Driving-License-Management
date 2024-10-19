namespace DVLD2.LocalDriverApplication.Controls
{
    partial class ucTakeTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSave = new System.Windows.Forms.Button();
            this.lbFee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbApplicantName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTrial = new System.Windows.Forms.Label();
            this.lbLicenseName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDriverLocalID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTestID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckPass = new System.Windows.Forms.RadioButton();
            this.ckFail = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txNote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::DVLD2.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(252, 665);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 35);
            this.btSave.TabIndex = 80;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbFee.Location = new System.Drawing.Point(196, 348);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(41, 23);
            this.lbFee.TabIndex = 78;
            this.lbFee.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 77;
            this.label6.Text = "Fee :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 75;
            this.label4.Text = "Date :";
            // 
            // lbApplicantName
            // 
            this.lbApplicantName.AutoSize = true;
            this.lbApplicantName.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicantName.Location = new System.Drawing.Point(196, 226);
            this.lbApplicantName.Name = "lbApplicantName";
            this.lbApplicantName.Size = new System.Drawing.Size(41, 23);
            this.lbApplicantName.TabIndex = 74;
            this.lbApplicantName.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 73;
            this.label5.Text = "Name :";
            // 
            // lbTrial
            // 
            this.lbTrial.AutoSize = true;
            this.lbTrial.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTrial.Location = new System.Drawing.Point(196, 266);
            this.lbTrial.Name = "lbTrial";
            this.lbTrial.Size = new System.Drawing.Size(41, 23);
            this.lbTrial.TabIndex = 72;
            this.lbTrial.Text = "[???]";
            // 
            // lbLicenseName
            // 
            this.lbLicenseName.AutoSize = true;
            this.lbLicenseName.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLicenseName.Location = new System.Drawing.Point(196, 186);
            this.lbLicenseName.Name = "lbLicenseName";
            this.lbLicenseName.Size = new System.Drawing.Size(41, 23);
            this.lbLicenseName.TabIndex = 71;
            this.lbLicenseName.Text = "[???]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(113, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 30);
            this.label13.TabIndex = 70;
            this.label13.Text = "Trial :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(68, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 30);
            this.label14.TabIndex = 69;
            this.label14.Text = "D.License :";
            // 
            // lbDriverLocalID
            // 
            this.lbDriverLocalID.AutoSize = true;
            this.lbDriverLocalID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriverLocalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDriverLocalID.Location = new System.Drawing.Point(196, 146);
            this.lbDriverLocalID.Name = "lbDriverLocalID";
            this.lbDriverLocalID.Size = new System.Drawing.Size(41, 23);
            this.lbDriverLocalID.TabIndex = 68;
            this.lbDriverLocalID.Text = "[???]";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(100, 142);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 30);
            this.label24.TabIndex = 67;
            this.label24.Text = "D..L.ID :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitle.Location = new System.Drawing.Point(107, 84);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(164, 50);
            this.lbTitle.TabIndex = 65;
            this.lbTitle.Text = "Test Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD2.Properties.Resources.Test_32;
            this.pictureBox1.Location = new System.Drawing.Point(147, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDate.Location = new System.Drawing.Point(196, 309);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(41, 23);
            this.lbDate.TabIndex = 81;
            this.lbDate.Text = "[???]";
            // 
            // lbTestID
            // 
            this.lbTestID.AutoSize = true;
            this.lbTestID.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTestID.Location = new System.Drawing.Point(196, 386);
            this.lbTestID.Name = "lbTestID";
            this.lbTestID.Size = new System.Drawing.Size(41, 23);
            this.lbTestID.TabIndex = 83;
            this.lbTestID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 30);
            this.label8.TabIndex = 82;
            this.label8.Text = "Test ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 84;
            this.label2.Text = "Result :";
            // 
            // ckPass
            // 
            this.ckPass.AutoSize = true;
            this.ckPass.Checked = true;
            this.ckPass.Location = new System.Drawing.Point(147, 451);
            this.ckPass.Name = "ckPass";
            this.ckPass.Size = new System.Drawing.Size(60, 21);
            this.ckPass.TabIndex = 85;
            this.ckPass.TabStop = true;
            this.ckPass.Text = "Pass ";
            this.ckPass.UseVisualStyleBackColor = true;
            // 
            // ckFail
            // 
            this.ckFail.AutoSize = true;
            this.ckFail.Location = new System.Drawing.Point(240, 451);
            this.ckFail.Name = "ckFail";
            this.ckFail.Size = new System.Drawing.Size(47, 21);
            this.ckFail.TabIndex = 86;
            this.ckFail.Text = "Fail";
            this.ckFail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 87;
            this.label3.Text = "Note :";
            // 
            // txNote
            // 
            this.txNote.Location = new System.Drawing.Point(53, 522);
            this.txNote.Multiline = true;
            this.txNote.Name = "txNote";
            this.txNote.Size = new System.Drawing.Size(309, 137);
            this.txNote.TabIndex = 88;
            // 
            // ucTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckFail);
            this.Controls.Add(this.ckPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTestID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbApplicantName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTrial);
            this.Controls.Add(this.lbLicenseName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbDriverLocalID);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucTakeTest";
            this.Size = new System.Drawing.Size(398, 712);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbApplicantName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTrial;
        private System.Windows.Forms.Label lbLicenseName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbDriverLocalID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTestID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ckPass;
        private System.Windows.Forms.RadioButton ckFail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNote;
    }
}
