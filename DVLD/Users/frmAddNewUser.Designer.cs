namespace DVLD2.Users
{
    partial class frmAddNewUser
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.ckIsActive = new System.Windows.Forms.CheckBox();
            this.txConfrimPassword = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ucUserInfoWithFilter1 = new DVLD2.Users.ucPersonInfoWithFilter();
            this.tabControl1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitle.Location = new System.Drawing.Point(284, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 50);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 544);
            this.tabControl1.TabIndex = 2;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.ucUserInfoWithFilter1);
            this.tbPersonInfo.Controls.Add(this.button2);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(836, 515);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Personal Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLD2.Properties.Resources.Next_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(715, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Next";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.ckIsActive);
            this.tbLoginInfo.Controls.Add(this.txConfrimPassword);
            this.tbLoginInfo.Controls.Add(this.txPassword);
            this.tbLoginInfo.Controls.Add(this.txUserName);
            this.tbLoginInfo.Controls.Add(this.label6);
            this.tbLoginInfo.Controls.Add(this.label5);
            this.tbLoginInfo.Controls.Add(this.label4);
            this.tbLoginInfo.Controls.Add(this.lbUserID);
            this.tbLoginInfo.Controls.Add(this.label2);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(836, 515);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // ckIsActive
            // 
            this.ckIsActive.AutoSize = true;
            this.ckIsActive.Location = new System.Drawing.Point(214, 282);
            this.ckIsActive.Name = "ckIsActive";
            this.ckIsActive.Size = new System.Drawing.Size(81, 21);
            this.ckIsActive.TabIndex = 10;
            this.ckIsActive.Text = "Is Active";
            this.ckIsActive.UseVisualStyleBackColor = true;
            // 
            // txConfrimPassword
            // 
            this.txConfrimPassword.Location = new System.Drawing.Point(214, 232);
            this.txConfrimPassword.Name = "txConfrimPassword";
            this.txConfrimPassword.Size = new System.Drawing.Size(195, 24);
            this.txConfrimPassword.TabIndex = 9;
            this.txConfrimPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Check_Vlidate);
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(214, 176);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(195, 24);
            this.txPassword.TabIndex = 8;
            this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Check_Vlidate);
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(214, 120);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(195, 24);
            this.txUserName.TabIndex = 7;
            this.txUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txUserName.Validating += new System.ComponentModel.CancelEventHandler(this.Check_Vlidate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confrim Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "User Name :";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(214, 65);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(64, 26);
            this.lbUserID.TabIndex = 3;
            this.lbUserID.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::DVLD2.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(614, 644);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(110, 35);
            this.btClose.TabIndex = 18;
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
            this.btSave.Location = new System.Drawing.Point(742, 644);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 35);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ucUserInfoWithFilter1
            // 
            this.ucUserInfoWithFilter1.Location = new System.Drawing.Point(17, 30);
            this.ucUserInfoWithFilter1.Name = "ucUserInfoWithFilter1";
            this.ucUserInfoWithFilter1.Size = new System.Drawing.Size(804, 412);
            this.ucUserInfoWithFilter1.TabIndex = 20;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 695);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckIsActive;
        private System.Windows.Forms.TextBox txConfrimPassword;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ucPersonInfoWithFilter ucUserInfoWithFilter1;
    }
}