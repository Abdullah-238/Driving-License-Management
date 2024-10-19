namespace DVLD2.Licenses
{
    partial class frmShowLicenseHistory
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
            this.components = new System.ComponentModel.Container();
            this.Titlte = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbLocal = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumbersOfLicenseInternation = new System.Windows.Forms.Label();
            this.lbLocalLicense = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucLicense1 = new DVLD2.Licenses.ucLicense();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlte
            // 
            this.Titlte.AutoSize = true;
            this.Titlte.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlte.Location = new System.Drawing.Point(264, 19);
            this.Titlte.Name = "Titlte";
            this.Titlte.Size = new System.Drawing.Size(332, 50);
            this.Titlte.TabIndex = 46;
            this.Titlte.Text = "Show History License";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(779, 750);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 34);
            this.btClose.TabIndex = 50;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(6, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 288);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licenses";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbLocal);
            this.tabControl1.Controls.Add(this.tpInternational);
            this.tabControl1.Location = new System.Drawing.Point(7, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tbLocal
            // 
            this.tbLocal.Controls.Add(this.lbLocalLicense);
            this.tbLocal.Controls.Add(this.label2);
            this.tbLocal.Controls.Add(this.dgvLocalLicenses);
            this.tbLocal.Location = new System.Drawing.Point(4, 25);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocal.Size = new System.Drawing.Size(868, 229);
            this.tbLocal.TabIndex = 0;
            this.tbLocal.Text = "Local";
            this.tbLocal.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AllowUserToOrderColumns = true;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(6, 7);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.RowHeadersWidth = 51;
            this.dgvLocalLicenses.RowTemplate.Height = 26;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(843, 180);
            this.dgvLocalLicenses.TabIndex = 0;
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.lbNumbersOfLicenseInternation);
            this.tpInternational.Controls.Add(this.label3);
            this.tpInternational.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternational.Location = new System.Drawing.Point(4, 25);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(868, 229);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(11, 6);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.RowHeadersWidth = 51;
            this.dgvInternationalLicenses.RowTemplate.Height = 26;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(846, 180);
            this.dgvInternationalLicenses.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "#Records :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbNumbersOfLicenseInternation
            // 
            this.lbNumbersOfLicenseInternation.AutoSize = true;
            this.lbNumbersOfLicenseInternation.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbersOfLicenseInternation.Location = new System.Drawing.Point(128, 196);
            this.lbNumbersOfLicenseInternation.Name = "lbNumbersOfLicenseInternation";
            this.lbNumbersOfLicenseInternation.Size = new System.Drawing.Size(25, 30);
            this.lbNumbersOfLicenseInternation.TabIndex = 10;
            this.lbNumbersOfLicenseInternation.Text = "0";
            this.lbNumbersOfLicenseInternation.Click += new System.EventHandler(this.lbNumbersOfLicense_Click);
            // 
            // lbLocalLicense
            // 
            this.lbLocalLicense.AutoSize = true;
            this.lbLocalLicense.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicense.Location = new System.Drawing.Point(128, 196);
            this.lbLocalLicense.Name = "lbLocalLicense";
            this.lbLocalLicense.Size = new System.Drawing.Size(25, 30);
            this.lbLocalLicense.TabIndex = 12;
            this.lbLocalLicense.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "#Records :";
            // 
            // ucLicense1
            // 
            this.ucLicense1.Location = new System.Drawing.Point(6, 82);
            this.ucLicense1.Name = "ucLicense1";
            this.ucLicense1.Size = new System.Drawing.Size(893, 367);
            this.ucLicense1.TabIndex = 51;
            // 
            // frmShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 805);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucLicense1);
            this.Controls.Add(this.Titlte);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbLocal.ResumeLayout(false);
            this.tbLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.tpInternational.ResumeLayout(false);
            this.tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlte;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ucLicense ucLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbLocal;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lbNumbersOfLicenseInternation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLocalLicense;
        private System.Windows.Forms.Label label2;
    }
}