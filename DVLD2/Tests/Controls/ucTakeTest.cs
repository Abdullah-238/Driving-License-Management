using DVLD2.Properties;
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

namespace DVLD2.LocalDriverApplication.Controls
{
    public partial class ucTakeTest : UserControl
    {
        int _TestAppoinmentID = 0;

        int _LocalApplicationID = 0; 
        public ucTakeTest()
        {
            InitializeComponent();
        }


        void _SetForm(int TestTypeID)
        {
            switch (TestTypeID)
            {
                case (int)clsTestTypes.enTestType.eVisonTest:
                    pictureBox1.Image = Resources.Vision_Test_32;
                    lbTitle.Text = "Vsion Test";
                    break;

                case (int)clsTestTypes.enTestType.eWrittenTest:
                    pictureBox1.Image = Resources.Written_Test_32;
                    lbTitle.Text = "Writeen Test";
                    break;

                case (int)clsTestTypes.enTestType.eStreetTest:
                    pictureBox1.Image = Resources.Street_Test_32;
                    lbTitle.Text = "Street Test";
                    break;
            }
        }


        public void LoadTakeTest(int LocalApplicationID , int TestAppoinmentID)
        {
            _TestAppoinmentID = TestAppoinmentID;

            _LocalApplicationID = LocalApplicationID; 

            clsTestAppointments TestAppointmen = clsTestAppointments.
                FindTestByTestAppointmentID(TestAppoinmentID);

            clsLocalDrivingLicenseApplications localDrivingLicenseApplications
                = clsLocalDrivingLicenseApplications.FindApplicationByLocalApplicationID(LocalApplicationID);

            _SetForm(TestAppointmen.TestTypeID);

            lbApplicantName.Text = clsPeople.Find(
                localDrivingLicenseApplications.ApplicantPersonID).FullName;
            lbDriverLocalID.Text = LocalApplicationID.ToString();
            lbFee.Text = TestAppointmen.PaidFees.ToString();
            lbLicenseName.Text = localDrivingLicenseApplications.LicenseClasses.ClassName;
            lbTrial.Text = clsTestAppointments.GetTestTrial(LocalApplicationID, (byte)TestAppointmen
                .TestTypeID).ToString();
            lbDate.Text = TestAppointmen.AppointmentDate.ToString();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            clsTest test = new clsTest();

            test.TestAppointmentID = _TestAppoinmentID;
            test.Notes = txNote.Text;
                if (ckPass.Checked)  
                test.TestResult = true; 
                else 
                test.TestResult = false;
            test.CreatedByUserID = clsCurrentUser.CurrentUser.UserID; 
            

            if (test.Save())
            {
                MessageBox.Show("Test saved succefully", "Done", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                btSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Test saved Faild", "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
    }
}
