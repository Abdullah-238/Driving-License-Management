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
    public partial class frmNewInternationalLicense : Form
    {
        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucLicenseWithFilter1_OnLicenseSelected(int obj)
        {
          
            lbLocalLicense.Text = ucLicenseWithFilter1.LicenseID.ToString();
            clsInternationalLicense internationalLicense
                = clsInternationalLicense.FindInternationalLicenseByLicenseID
                (ucLicenseWithFilter1.LicenseID);

            llShowLicneseHistory.Enabled = true;
            llShowLicenseInfo.Enabled = true;

            if (clsInternationalLicense.IsDriverHasActiveInternationalLicense(
                ucLicenseWithFilter1.LicenseID))
            {
                MessageBox.Show("This user has active international license",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InternationalApplicationDriverlbID.Text =
               internationalLicense.ApplicationID.ToString();
                lbInternationalAppID.Text =
                    internationalLicense.InternationalLicenseID.ToString();
                return; 
            }

            btIssue.Enabled = true;
        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            lbFee.Text = clsApplicationTypes.
                FindApplicationByApplicationTypeID((byte)clsApplications.enApplicationType.
                eNewInternationalLicense).ApplicationFees.ToString();
            lbExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName; 


        }

        private void btIssue_Click(object sender, EventArgs e)
        {
            clsInternationalLicense internationalLicense
                = new clsInternationalLicense();


            clsDriver Driver = clsDriver.FindDriverByDriverID(
                clsLicense.FindByLicenseID(ucLicenseWithFilter1.LicenseID).DriverID);     
            clsPeople Person = clsPeople.Find(Driver.PersonID);


            internationalLicense.ApplicationDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.ApplicationStatus = clsApplications.enStatus.eNew;
            internationalLicense.ApplicantPersonID = Person.PersonID;
            internationalLicense.ApplicationTypeID = (byte)clsApplications.
                enApplicationType.eNewInternationalLicense;
            internationalLicense.DriverID = Driver.DriverID;
            internationalLicense.PaidFees = clsApplicationTypes.
                FindApplicationByApplicationTypeID((byte)clsApplications.enApplicationType.
                eNewInternationalLicense).ApplicationFees;
            internationalLicense.IssuedUsingLocalLicenseID = ucLicenseWithFilter1.LicenseID;
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = clsCurrentUser.CurrentUser.UserID; 


            if (internationalLicense.Save())
            {
                InternationalApplicationDriverlbID.Text = internationalLicense.ApplicationID.ToString();
                lbInternationalAppID.Text = internationalLicense.InternationalLicenseID.ToString();
                btIssue.Enabled = false; 
                MessageBox.Show("Application saved succefully" , "Done" , MessageBoxButtons.OK
                    ,MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show("Application saved faild", "Error", MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory licenseHistory =
                new frmShowLicenseHistory(ucLicenseWithFilter1.LicenseID);

            licenseHistory.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo(ucLicenseWithFilter1.LicenseID);

            licenseInfo.ShowDialog();
        }
    }
}
