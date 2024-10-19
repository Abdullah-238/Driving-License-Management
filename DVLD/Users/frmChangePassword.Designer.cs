namespace DVLD2.Users
{
    partial class frmChangePassword
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
            this.ucUserInfo1 = new DVLD2.Users.ucUserInfo();
            this.txConfrimPassword = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCurrentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.Location = new System.Drawing.Point(0, 1);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(813, 395);
            this.ucUserInfo1.TabIndex = 0;
            // 
            // txConfrimPassword
            // 
            this.txConfrimPassword.Location = new System.Drawing.Point(232, 509);
            this.txConfrimPassword.Name = "txConfrimPassword";
            this.txConfrimPassword.Size = new System.Drawing.Size(195, 24);
            this.txConfrimPassword.TabIndex = 13;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(232, 458);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(195, 24);
            this.txPassword.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confrim Password :";
            // 
            // txCurrentPassword
            // 
            this.txCurrentPassword.Location = new System.Drawing.Point(232, 402);
            this.txCurrentPassword.Name = "txCurrentPassword";
            this.txCurrentPassword.Size = new System.Drawing.Size(195, 24);
            this.txCurrentPassword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Password :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD2.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(575, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::DVLD2.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(703, 565);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 35);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txCurrentPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txConfrimPassword);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ucUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucUserInfo ucUserInfo1;
        private System.Windows.Forms.TextBox txConfrimPassword;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCurrentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSave;
    }
}