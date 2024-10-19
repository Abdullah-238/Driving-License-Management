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

namespace DVLD2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
           clsUser User = 
                clsUser.FindByUserNameAndPassword(txUserName.Text, txPassword.Text);

            if (User != null)
            {
                if (!User.IsActive)
                {
                    MessageBox.Show("UserName not Active please contact your admin", "error");
                    return;
                }


            clsCurrentUser.CurrentUser = User;

                frmMain Main = new frmMain(this);

                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or Password not correct please check then try again", "Done");
            }

        }
    }
}
