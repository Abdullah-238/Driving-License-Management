using DVLD2.Licenses;
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
    public partial class frmRealeaseLicense : Form
    {
        int LicenseID = 0;

        clsDetainedLicenses DetainedLicense; 
        public frmRealeaseLicense()
        {
            InitializeComponent();
        }

        private void llShowLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory
                LicenseHistory = new frmShowLicenseHistory(LicenseID);

            LicenseHistory.ShowDialog();

        }

        private void ucLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            LicenseID = ucLicenseWithFilter1.LicenseID;

            DetainedLicense =
               clsDetainedLicenses.FindByLicenseID(LicenseID);

            if (!clsDetainedLicenses.IsLicenseDetained(LicenseID))
            {
                MessageBox.Show("License not detained", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            decimal ApplicationFee = clsApplicationTypes.FindApplicationByApplicationTypeID
              ((byte)clsApplications
              .enApplicationType.eReleaseDetainedDrivingLicsense).ApplicationFees;

            decimal DetainedFee = DetainedLicense.FineFees;

            decimal Total = ApplicationFee + DetainedFee;



            llShowLicenseInfo.Enabled = true;
            llShowLicneseHistory.Enabled = true;
            btIssue.Enabled = true;

            lbLicenseID.Text = LicenseID.ToString();
            lbDetainedID.Text = DetainedLicense.DetainID.ToString();
            lbDetainedDate.Text = DetainedLicense.DetainDate.ToString();
            lbApplicationFee.Text = ApplicationFee.ToString();
            lbFineFee.Text = DetainedFee.ToString();
            lbTotalFee.Text = Total.ToString();
            lbCreatedBy.Text = 
                clsUser.FindUserByUserID(DetainedLicense.CreatedByUserID).UserName;


        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo(LicenseID);

            licenseInfo.ShowDialog();
        }

        private void frmRealeaseLicense_Load(object sender, EventArgs e)
        {

        }

        private void btIssue_Click(object sender, EventArgs e)
        {
            
            
            if (DetainedLicense.ReleaseDetainedLicense(clsCurrentUser.CurrentUser.UserID))
            {
                MessageBox.Show("License Realease succusfully" , "Done" 
                    ,MessageBoxButtons.OK , MessageBoxIcon.Information );
                lbApplicationID.Text = DetainedLicense.ReleaseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("License Realease Faild", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucLicenseWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
