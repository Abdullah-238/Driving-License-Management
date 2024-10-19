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
using System.Xml.Linq;

namespace DVLD2
{
    public partial class frmReplaceForLostOrDemage : Form
    {
        int _LicenseID = 0;

        clsLicense OldLicense;
        public frmReplaceForLostOrDemage()
        {
            InitializeComponent();
        }

        private void frmReplaceForLostOrDemage_Load(object sender, EventArgs e)
        {

        }

        private void btIssue_Click(object sender, EventArgs e)
        {
            clsLicense NewLicense = OldLicense.
                ReplaceDriveringLicenseForDemaged(
               clsCurrentUser.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Applcation Issue Faild", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License Replacement succefully", "Done",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbRenewLicenseApp.Text = NewLicense.ApplicationID.ToString();
            lbRenewLicenseID.Text = NewLicense.LicenseID.ToString();
            btIssue.Enabled = false;
            llShowLicenseInfo.Enabled = true;
        }
        void _Load()
        {
            decimal ApplicationFee = clsApplicationTypes.FindApplicationByApplicationTypeID
                ((byte)clsApplications.enApplicationType
                .eReplacementforaDamagedDrivingLicense).ApplicationFees;

         
            lbApplicationDate.Text = DateTime.Now.ToString();
           
            lbApplicationFee.Text = ApplicationFee.ToString();
            lbOldLicenseID.Text = _LicenseID.ToString();
            lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;
        }

        private void ucLicenseWithFilter1_OnLicenseSelected_1(int obj)
        {
            _LicenseID = ucLicenseWithFilter1.LicenseID;

            OldLicense = clsLicense.FindByLicenseID(_LicenseID);

            clsLicense.IsLicenseActive(_LicenseID);

            llShowLicneseHistory.Enabled = true;

            if (!clsLicense.IsLicenseActive(_LicenseID))
            {
                MessageBox.Show("This license not active", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            btIssue.Enabled = true;

            _Load();
        }

        private void llShowLicneseHistory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory showLicenseHistory = new frmShowLicenseHistory(_LicenseID);

            showLicenseHistory.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo showLicenseHistory = new frmLicenseInfo(_LicenseID);

            showLicenseHistory.ShowDialog();
        }
    }
}
