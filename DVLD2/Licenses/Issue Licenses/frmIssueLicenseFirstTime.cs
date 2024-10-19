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
using static DVLD2.clsLicense;

namespace DVLD2
{
    public partial class frmIssueLicenseFirstTime : Form
    {
        int LicenseID = 0; 

        int _LocalDriverApplicationID = 0;

        clsLocalDrivingLicenseApplications localDrivingLicenseApplications;
        public frmIssueLicenseFirstTime(int LocalDriverApplicationID)
        {
            InitializeComponent();

            _LocalDriverApplicationID = LocalDriverApplicationID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ucApplicationInfo1.LoadApplicationInfo(_LocalDriverApplicationID);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            LicenseID =
                localDrivingLicenseApplications.IssueLicenseForFirstTime(textBox1.Text,
                clsCurrentUser.CurrentUser.UserID);



            if (LicenseID != -1)
            {
                MessageBox.Show("License Issue succefully", "Done", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Driver Saved faild", "Done", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
    }
}
