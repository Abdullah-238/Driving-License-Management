namespace DVLD2.LocalDriverApplication
{
    partial class frmListOfLocalDriverApplication
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
            this.txValue = new System.Windows.Forms.TextBox();
            this.lbNumbersOfApplications = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAllApplication = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisonTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDriverLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddNewApplication = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApplication)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txValue
            // 
            this.txValue.Location = new System.Drawing.Point(218, 140);
            this.txValue.Name = "txValue";
            this.txValue.Size = new System.Drawing.Size(145, 24);
            this.txValue.TabIndex = 19;
            this.txValue.TextChanged += new System.EventHandler(this.txValue_TextChanged);
            this.txValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValue_KeyPress);
            // 
            // lbNumbersOfApplications
            // 
            this.lbNumbersOfApplications.AutoSize = true;
            this.lbNumbersOfApplications.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbersOfApplications.Location = new System.Drawing.Point(123, 499);
            this.lbNumbersOfApplications.Name = "lbNumbersOfApplications";
            this.lbNumbersOfApplications.Size = new System.Drawing.Size(25, 30);
            this.lbNumbersOfApplications.TabIndex = 18;
            this.lbNumbersOfApplications.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "#Records :";
            // 
            // dgvAllApplication
            // 
            this.dgvAllApplication.AllowUserToAddRows = false;
            this.dgvAllApplication.AllowUserToDeleteRows = false;
            this.dgvAllApplication.AllowUserToOrderColumns = true;
            this.dgvAllApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllApplication.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllApplication.Location = new System.Drawing.Point(1, 170);
            this.dgvAllApplication.Name = "dgvAllApplication";
            this.dgvAllApplication.ReadOnly = true;
            this.dgvAllApplication.RowHeadersWidth = 51;
            this.dgvAllApplication.RowTemplate.Height = 26;
            this.dgvAllApplication.Size = new System.Drawing.Size(969, 304);
            this.dgvAllApplication.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueDriverLicenseFirstTimeToolStripMenuItem,
            this.sechduleTestToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(289, 168);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // sechduleTestToolStripMenuItem
            // 
            this.sechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVisonTestToolStripMenuItem,
            this.sechduleWrittenTestToolStripMenuItem,
            this.sechduleStreetTestToolStripMenuItem});
            this.sechduleTestToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Test_32;
            this.sechduleTestToolStripMenuItem.Name = "sechduleTestToolStripMenuItem";
            this.sechduleTestToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.sechduleTestToolStripMenuItem.Text = "Sechdule Test";
            // 
            // sechduleVisonTestToolStripMenuItem
            // 
            this.sechduleVisonTestToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Vision_Test_32;
            this.sechduleVisonTestToolStripMenuItem.Name = "sechduleVisonTestToolStripMenuItem";
            this.sechduleVisonTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sechduleVisonTestToolStripMenuItem.Text = "Sechdule Vison Test";
            this.sechduleVisonTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleVisonTestToolStripMenuItem_Click);
            // 
            // sechduleWrittenTestToolStripMenuItem
            // 
            this.sechduleWrittenTestToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Written_Test_32;
            this.sechduleWrittenTestToolStripMenuItem.Name = "sechduleWrittenTestToolStripMenuItem";
            this.sechduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sechduleWrittenTestToolStripMenuItem.Text = "Sechdule Written Test";
            this.sechduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleWrittenTestToolStripMenuItem_Click);
            // 
            // sechduleStreetTestToolStripMenuItem
            // 
            this.sechduleStreetTestToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Street_Test_32;
            this.sechduleStreetTestToolStripMenuItem.Name = "sechduleStreetTestToolStripMenuItem";
            this.sechduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sechduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            this.sechduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleStreetTestToolStripMenuItem_Click);
            // 
            // issueDriverLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Image = global::DVLD2.Properties.Resources.IssueDrivingLicense_321;
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Name = "issueDriverLicenseFirstTimeToolStripMenuItem";
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Text = "Issue Driver License (First Time)";
            this.issueDriverLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDriverLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "L.D.APP.ID",
            "National NO",
            "Full Name",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(72, 140);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 24);
            this.cbFilter.TabIndex = 13;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(287, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Local Driver License Applications";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(860, 499);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 16;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD2.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(476, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btAddNewApplication
            // 
            this.btAddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddNewApplication.Image = global::DVLD2.Properties.Resources.Manage_Applications_32;
            this.btAddNewApplication.Location = new System.Drawing.Point(909, 116);
            this.btAddNewApplication.Name = "btAddNewApplication";
            this.btAddNewApplication.Size = new System.Drawing.Size(61, 48);
            this.btAddNewApplication.TabIndex = 15;
            this.btAddNewApplication.UseVisualStyleBackColor = true;
            this.btAddNewApplication.Click += new System.EventHandler(this.btAddNewApplication_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD2.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD2.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // frmListOfLocalDriverApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 554);
            this.Controls.Add(this.txValue);
            this.Controls.Add(this.lbNumbersOfApplications);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddNewApplication);
            this.Controls.Add(this.dgvAllApplication);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListOfLocalDriverApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListOfLocalDriverApplication";
            this.Load += new System.EventHandler(this.frmListOfLocalDriverApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApplication)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txValue;
        private System.Windows.Forms.Label lbNumbersOfApplications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAddNewApplication;
        private System.Windows.Forms.DataGridView dgvAllApplication;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisonTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDriverLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
    }
}