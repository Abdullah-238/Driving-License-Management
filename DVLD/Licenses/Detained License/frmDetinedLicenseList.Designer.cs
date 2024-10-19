namespace DVLD2.Detained_License
{
    partial class frmDetinedLicenseList
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
            this.cbIsRealease = new System.Windows.Forms.ComboBox();
            this.dgvAllDetainedLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumbersOfDetainedLicense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txValue = new System.Windows.Forms.TextBox();
            this.btRelease = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btDetainedLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDetainedLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIsRealease
            // 
            this.cbIsRealease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsRealease.FormattingEnabled = true;
            this.cbIsRealease.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbIsRealease.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsRealease.Location = new System.Drawing.Point(225, 146);
            this.cbIsRealease.Name = "cbIsRealease";
            this.cbIsRealease.Size = new System.Drawing.Size(106, 24);
            this.cbIsRealease.TabIndex = 31;
            this.cbIsRealease.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // dgvAllDetainedLicense
            // 
            this.dgvAllDetainedLicense.AllowUserToAddRows = false;
            this.dgvAllDetainedLicense.AllowUserToDeleteRows = false;
            this.dgvAllDetainedLicense.AllowUserToOrderColumns = true;
            this.dgvAllDetainedLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDetainedLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllDetainedLicense.Location = new System.Drawing.Point(8, 175);
            this.dgvAllDetainedLicense.Name = "dgvAllDetainedLicense";
            this.dgvAllDetainedLicense.ReadOnly = true;
            this.dgvAllDetainedLicense.RowHeadersWidth = 51;
            this.dgvAllDetainedLicense.RowTemplate.Height = 26;
            this.dgvAllDetainedLicense.Size = new System.Drawing.Size(1042, 304);
            this.dgvAllDetainedLicense.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetilesToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(269, 114);
            // 
            // showDetilesToolStripMenuItem
            // 
            this.showDetilesToolStripMenuItem.Image = global::DVLD2.Properties.Resources.PersonDetails_32;
            this.showDetilesToolStripMenuItem.Name = "showDetilesToolStripMenuItem";
            this.showDetilesToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.showDetilesToolStripMenuItem.Text = "Show Person Detiles";
            this.showDetilesToolStripMenuItem.Click += new System.EventHandler(this.showDetilesToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD2.Properties.Resources.License_View_321;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.addNewPersonToolStripMenuItem.Text = "Show License Detiles";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::DVLD2.Properties.Resources.PersonLicenseHistory_32;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.updateToolStripMenuItem.Text = "Show Person License History";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Release_Detained_License_322;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.sendEmailToolStripMenuItem.Text = "Release Detained License";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Detained ID",
            "National NO",
            "Full Name",
            "Release Application ID",
            "Is Realease"});
            this.cbFilter.Location = new System.Drawing.Point(79, 145);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 24);
            this.cbFilter.TabIndex = 24;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(421, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 50);
            this.label1.TabIndex = 21;
            this.label1.Text = "Detained Licenses List ";
            // 
            // lbNumbersOfDetainedLicense
            // 
            this.lbNumbersOfDetainedLicense.AutoSize = true;
            this.lbNumbersOfDetainedLicense.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbersOfDetainedLicense.Location = new System.Drawing.Point(130, 504);
            this.lbNumbersOfDetainedLicense.Name = "lbNumbersOfDetainedLicense";
            this.lbNumbersOfDetainedLicense.Size = new System.Drawing.Size(25, 30);
            this.lbNumbersOfDetainedLicense.TabIndex = 29;
            this.lbNumbersOfDetainedLicense.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "#Records :";
            // 
            // txValue
            // 
            this.txValue.Location = new System.Drawing.Point(225, 145);
            this.txValue.Name = "txValue";
            this.txValue.Size = new System.Drawing.Size(145, 24);
            this.txValue.TabIndex = 30;
            this.txValue.TextChanged += new System.EventHandler(this.txValue_TextChanged);
            this.txValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValue_KeyPress);
            // 
            // btRelease
            // 
            this.btRelease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRelease.Image = global::DVLD2.Properties.Resources.Release_Detained_License_321;
            this.btRelease.Location = new System.Drawing.Point(894, 126);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(75, 44);
            this.btRelease.TabIndex = 32;
            this.btRelease.UseVisualStyleBackColor = true;
            this.btRelease.Click += new System.EventHandler(this.btRelease_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(940, 494);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 27;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDetainedLicense
            // 
            this.btDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDetainedLicense.Image = global::DVLD2.Properties.Resources.Detain_322;
            this.btDetainedLicense.Location = new System.Drawing.Point(975, 126);
            this.btDetainedLicense.Name = "btDetainedLicense";
            this.btDetainedLicense.Size = new System.Drawing.Size(75, 44);
            this.btDetainedLicense.TabIndex = 26;
            this.btDetainedLicense.UseVisualStyleBackColor = true;
            this.btDetainedLicense.Click += new System.EventHandler(this.btDetainedLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD2.Properties.Resources.Detain_641;
            this.pictureBox1.Location = new System.Drawing.Point(565, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmDetinedLicenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 547);
            this.Controls.Add(this.btRelease);
            this.Controls.Add(this.cbIsRealease);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDetainedLicense);
            this.Controls.Add(this.dgvAllDetainedLicense);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNumbersOfDetainedLicense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetinedLicenseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetinedLicenseList";
            this.Load += new System.EventHandler(this.frmDetinedLicenseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDetainedLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIsRealease;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDetainedLicense;
        private System.Windows.Forms.DataGridView dgvAllDetainedLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNumbersOfDetainedLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txValue;
        private System.Windows.Forms.Button btRelease;
    }
}