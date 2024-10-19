namespace DVLD2.Licenses
{
    partial class frmLicenseInfo
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
            this.Titlte = new System.Windows.Forms.Label();
            this.ucLicense1 = new DVLD2.Licenses.ucLicense();
            this.SuspendLayout();
            // 
            // Titlte
            // 
            this.Titlte.AutoSize = true;
            this.Titlte.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlte.Location = new System.Drawing.Point(320, 25);
            this.Titlte.Name = "Titlte";
            this.Titlte.Size = new System.Drawing.Size(196, 50);
            this.Titlte.TabIndex = 23;
            this.Titlte.Text = "License Info";
            // 
            // ucLicense1
            // 
            this.ucLicense1.Location = new System.Drawing.Point(4, 87);
            this.ucLicense1.Name = "ucLicense1";
            this.ucLicense1.Size = new System.Drawing.Size(893, 367);
            this.ucLicense1.TabIndex = 24;
            // 
            // frmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 481);
            this.Controls.Add(this.ucLicense1);
            this.Controls.Add(this.Titlte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicenseInfo";
            this.Load += new System.EventHandler(this.frmLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlte;
        private ucLicense ucLicense1;
    }
}