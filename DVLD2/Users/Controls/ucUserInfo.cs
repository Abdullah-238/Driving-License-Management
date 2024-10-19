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
    public partial class ucUserInfo : UserControl
    {
        int _UserID;

        clsUser _User;
        public ucUserInfo()
        {
            InitializeComponent();
        }


        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;

            _User = clsUser.FindUserByUserID(UserID);

            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " +
                    UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillFormWithInfo();

        }

        void FillFormWithInfo()
        {
            ucPersonInfo1._LoadPersonInfo(_User.PersonID);

            lbUserName.Text = _User.UserName;
            lbUserID.Text = _UserID.ToString();

            if (_User.IsActive)
                lbIsActive.Text = "Yes";
            else
                lbIsActive.Text = "No";
        }

        void _ResetPersonInfo()
        {
            ucPersonInfo1.ResetPersonInfo();
            lbUserID.Text = "[???]";
            lbUserName.Text = "[???]";
            lbIsActive.Text = "No";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void ucPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
