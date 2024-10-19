using DVLD2.Detained_License;
using DVLD2.Licenses.Detained_License;
using DVLD2.LocalDriverApplication;
using DVLD2.Test_Types;
using DVLD2.Users;
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
    public partial class frmMain : Form
    {
        LoginScreen _Login; 
        public frmMain(LoginScreen Login)
        {
            InitializeComponent();

            _Login = Login;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople people = new frmPeople();

            people.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frmListUsers = new frmListUsers();

            frmListUsers.ShowDialog();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsCurrentUser.CurrentUser.UserID;

            frmUserInfo UserInfo = new frmUserInfo(UserID);

            UserInfo.ShowDialog();


        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsCurrentUser.CurrentUser.UserID;

            frmChangePassword changePassword = new frmChangePassword(UserID);

            changePassword.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            clsCurrentUser.CurrentUser = null; 

            _Login.Show();
        }

        private void mangeApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeApplicationTypes MangeApplicationTypes = new frmMangeApplicationTypes();

            MangeApplicationTypes.ShowDialog();
        }

        private void mangeTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestTypes TestType = new frmTestTypes();

            TestType.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalApplication localApplication = new frmAddNewLocalApplication();

            localApplication.ShowDialog();

        }

        private void mangeDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetinedLicenseList DetainedLicense = new frmDetinedLicenseList();

            DetainedLicense.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainedLicense detainedLicense 
                = new frmDetainedLicense();

            detainedLicense.ShowDialog();
        }

        private void localLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfLocalDriverApplication localDriverApplication = new frmListOfLocalDriverApplication();

            localDriverApplication.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense NewInternationalLicense = new frmNewInternationalLicense();

            NewInternationalLicense.ShowDialog();
        }

        private void mangeApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void interNationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense NewInternationalLicense = new frmNewInternationalLicense();

            NewInternationalLicense.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicenseDriver renewLicenseDriver =
                new frmRenewLicenseDriver();

            renewLicenseDriver.ShowDialog();

        }

        private void replacementForLostOrDemageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceForLostOrDemage frmReplaceForLost
                = new frmReplaceForLostOrDemage();

            frmReplaceForLost.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRealeaseLicense realeaseLicense = new frmRealeaseLicense();

            realeaseLicense.ShowDialog();
        }
    }
}
