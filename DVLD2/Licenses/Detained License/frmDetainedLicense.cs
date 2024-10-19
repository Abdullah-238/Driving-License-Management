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

namespace DVLD2.Licenses.Detained_License
{
    public partial class frmDetainedLicense : Form
    {
        int LicenseID = 0; 
        public frmDetainedLicense()
        {
            InitializeComponent();
        }

        private void ucLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            LicenseID =  ucLicenseWithFilter1.LicenseID;

            if (clsDetainedLicenses.IsLicenseDetained(LicenseID))
            {
                MessageBox.Show("this license already " +
                    "detained" , "Error" , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            llShowLicneseHistory.Enabled = true; 
            llShowLicenseInfo.Enabled = true;

            lbDetainedDate.Text = DateTime.Now.ToString();
            lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;
            lbLicenseID.Text = LicenseID.ToString();
            btIssue.Enabled = true;



        }

        private void frmDetainedLicense_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo(LicenseID);

            licenseInfo.ShowDialog();
        }

        private void llShowLicneseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory licenseHistory 
                = new frmShowLicenseHistory(LicenseID);

            licenseHistory.ShowDialog();
        }

        private void btIssue_Click(object sender, EventArgs e)
        {
            clsDetainedLicenses detainedLicense = new clsDetainedLicenses();

            detainedLicense.CreatedByUserID = clsCurrentUser.CurrentUser.UserID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = decimal.Parse( textBox1.Text.Trim());
            detainedLicense.LicenseID = LicenseID;

            if (detainedLicense.Save())
            {
                MessageBox.Show("License detained succesfully" , "done" ,
                    MessageBoxButtons.OK , MessageBoxIcon.Information );
                lbDetainedID.Text = detainedLicense.DetainID.ToString();
                btIssue.Enabled = false; 
            }
            else
            {
                MessageBox.Show("License detained succesfully", "done",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
