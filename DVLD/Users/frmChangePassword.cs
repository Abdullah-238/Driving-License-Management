using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2.Users
{
    public partial class frmChangePassword : Form
    {
        int _UserID = 0;

        clsUser User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ucUserInfo1.LoadUserInfo(_UserID);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            User = clsUser.FindUserByUserID(_UserID);

            if (txPassword.Text != txConfrimPassword.Text)
            {
                MessageBox.Show("password deosn't match", "error");
                return; 
            }
            if (User.Password != txCurrentPassword.Text.Trim())
            {
                MessageBox.Show("values you enterd not correct please check then try again", "erorr");
                return; 
            }

            User.Password = txPassword.Text.Trim();

            if (User.Save())
            {
                MessageBox.Show("Password changed succesfully", "Done");
            }
            else
            {
                MessageBox.Show("Password changed Falid", "erorr");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
