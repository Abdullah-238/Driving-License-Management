namespace DVLD2.Test_Types
{
    partial class frmUpdateTest
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
            this.txFee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTestTypeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txDescrapation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txFee
            // 
            this.txFee.Location = new System.Drawing.Point(82, 304);
            this.txFee.Name = "txFee";
            this.txFee.Size = new System.Drawing.Size(195, 24);
            this.txFee.TabIndex = 27;
            this.txFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txFee_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fee :";
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(82, 116);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(195, 24);
            this.txTitle.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = " Title :";
            // 
            // lbTestTypeID
            // 
            this.lbTestTypeID.AutoSize = true;
            this.lbTestTypeID.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTypeID.Location = new System.Drawing.Point(77, 71);
            this.lbTestTypeID.Name = "lbTestTypeID";
            this.lbTestTypeID.Size = new System.Drawing.Size(64, 26);
            this.lbTestTypeID.TabIndex = 23;
            this.lbTestTypeID.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitle.Location = new System.Drawing.Point(45, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(206, 36);
            this.lbTitle.TabIndex = 21;
            this.lbTitle.Text = "Update Test Type";
            // 
            // txDescrapation
            // 
            this.txDescrapation.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescrapation.Location = new System.Drawing.Point(82, 158);
            this.txDescrapation.Multiline = true;
            this.txDescrapation.Name = "txDescrapation";
            this.txDescrapation.Size = new System.Drawing.Size(195, 140);
            this.txDescrapation.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = " Desc :";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(39, 353);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 29;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::DVLD2.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(167, 353);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 35);
            this.btSave.TabIndex = 28;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmUpdateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 406);
            this.Controls.Add(this.txDescrapation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTestTypeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateTest";
            this.Load += new System.EventHandler(this.frmUpdateTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTestTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txDescrapation;
        private System.Windows.Forms.Label label3;
    }
}