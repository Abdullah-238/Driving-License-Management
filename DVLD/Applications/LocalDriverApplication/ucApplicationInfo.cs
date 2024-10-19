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

namespace DVLD2.LocalDriverApplication
{
    public partial class ucApplicationInfo : UserControl
    {
        clsLocalDrivingLicenseApplications LocalDriverApplication; 
        public ucApplicationInfo()
        {
            InitializeComponent();
        }


        public void LoadApplicationInfo(int LocalDriverApplicationID)
        {
            LocalDriverApplication = clsLocalDrivingLicenseApplications.
                FindApplicationByLocalApplicationID(LocalDriverApplicationID);


            if (LocalDriverApplication == null)
                return; 

            lbDriverLocalID.Text = LocalDriverApplicationID .ToString();
            lbLicenseName.Text = LocalDriverApplication.LicenseClasses.ClassName;

            lbPassedTest.Text = 
                clsTestAppointments.GetPassedTestCount(LocalDriverApplicationID) + "/3"; 

            lbID.Text = LocalDriverApplication.ApplicationID.ToString();
            lbStatus.Text = LocalDriverApplication.StatusText;
            lbFees.Text = LocalDriverApplication.PaidFees.ToString();
            lbType.Text = clsApplicationTypes.FindApplicationByApplicationTypeID(
                LocalDriverApplication.ApplicationTypeID).ApplicationTypeTitle;
            lbApplicant.Text = clsPeople.Find(LocalDriverApplication.ApplicantPersonID).FullName;
            lbDate.Text = LocalDriverApplication.ApplicationDate.ToString();
            lbStatusDate.Text = LocalDriverApplication.LastStatusDate.ToString();
            lbCreatedBy.Text = clsUser.FindByPersonID(LocalDriverApplication.CreatedByUserID).UserName; 
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
