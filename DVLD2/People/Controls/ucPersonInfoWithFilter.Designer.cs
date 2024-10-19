namespace DVLD2.Users
{
    partial class ucPersonInfoWithFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAddNewUser = new System.Windows.Forms.Button();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.ucPersonInfo1 = new DVLD2.ucPersonInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.btAddNewUser);
            this.groupBox1.Controls.Add(this.cbSearchBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txSearch);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btSearch
            // 
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSearch.Image = global::DVLD2.Properties.Resources.SearchPerson;
            this.btSearch.Location = new System.Drawing.Point(643, 36);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(63, 43);
            this.btSearch.TabIndex = 17;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAddNewUser
            // 
            this.btAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddNewUser.Image = global::DVLD2.Properties.Resources.Add_Person_40;
            this.btAddNewUser.Location = new System.Drawing.Point(712, 36);
            this.btAddNewUser.Name = "btAddNewUser";
            this.btAddNewUser.Size = new System.Drawing.Size(62, 43);
            this.btAddNewUser.TabIndex = 16;
            this.btAddNewUser.UseVisualStyleBackColor = true;
            this.btAddNewUser.Click += new System.EventHandler(this.btAddNewUser_Click);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cbSearchBy.Location = new System.Drawing.Point(105, 45);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(206, 24);
            this.cbSearchBy.TabIndex = 2;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By :";
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(328, 45);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(297, 24);
            this.txSearch.TabIndex = 0;
            this.txSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearch_KeyPress);
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(0, 125);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(807, 291);
            this.ucPersonInfo1.TabIndex = 3;
            // 
            // ucPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPersonInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(804, 412);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucPersonInfo ucPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btAddNewUser;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSearch;
    }
}
