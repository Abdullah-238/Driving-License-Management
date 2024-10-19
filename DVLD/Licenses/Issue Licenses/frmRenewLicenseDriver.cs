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
using static DVLD2.clsLicense;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD2
{
    public partial class frmRenewLicenseDriver : Form
    {
        int _LicenseID = 0;

        clsLicense OldLicense; 
        public frmRenewLicenseDriver()
        {
            InitializeComponent();

        }

        private void btIssue_Click(object sender, EventArgs e)
        {

            clsLicense NewLicense = OldLicense.RenewDriverLicense(txNote.Text,
                clsCurrentUser.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Applcation Issue Faild", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License Issue succefully", "Done",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbRenewLicenseApp.Text = NewLicense.ApplicationID.ToString();
            lbRenewLicenseID.Text = NewLicense.LicenseID.ToString();
            btIssue.Enabled = false;
            llShowLicenseInfo.Enabled = true; 
            _LicenseID = NewLicense.LicenseID;

        }

        private void ucLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = ucLicenseWithFilter1.LicenseID; 

            OldLicense = clsLicense.FindByLicenseID(_LicenseID);

            clsLicense.IsLicenseActive(_LicenseID);

            llShowLicneseHistory.Enabled = true;

            if (!clsLicense.IsLicenseActive(_LicenseID))
            {
                MessageBox.Show("This license not active" , "Error" , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }

            btIssue.Enabled = true;

            _Load();
        }

        void _Load()
        {
            decimal ApplicationFee = clsApplicationTypes.FindApplicationByApplicationTypeID
                ((byte)clsApplications.enApplicationType
                .eRenewDrivingLicense).ApplicationFees;

            decimal LicenseFee = clsLicenseClasses.
                FindLicenseByLicenseClassID(OldLicense.LicenseClass).ClassFees;

            decimal Totoal = LicenseFee + ApplicationFee;


            lbApplicationDate.Text = DateTime.Now.ToString();
            lbIssueDate.Text = DateTime.Now.ToString();
            lbLicenseFee.Text = LicenseFee.ToString();
            lbApplicationFee.Text = ApplicationFee.ToString();
            lbOldLicenseID.Text = _LicenseID.ToString();
            lbExpirationDate.Text = DateTime.Now.AddYears(clsLicenseClasses.
                FindLicenseByLicenseClassID(OldLicense.LicenseClass).DefaultValidityLength).ToString();
            lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;
            lbTotalFee.Text = Totoal.ToString();
        }
        private void frmRenewLicenseDriver_Load(object sender, EventArgs e)
        {
            


        }

        private void llShowLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory showLicenseHistory = new frmShowLicenseHistory(_LicenseID);

            showLicenseHistory.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo showLicenseHistory = new frmLicenseInfo(_LicenseID);

            showLicenseHistory.ShowDialog();
        }
    }
}
