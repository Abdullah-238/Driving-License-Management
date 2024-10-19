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
    public partial class ucAddNewTest : UserControl
    {
        int _LocalApplicationID = 0;

        int RetakeTestID = -1;

        clsTestTypes.enTestType _TestTypeID;

        clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;

        clsTestAppointments _TestAppointments;

        enum enRetakeTest { FirstTimeSchdule = 1 , ReTakeTestSchdule = 2}

        enRetakeTest ReTakeTestSchdule = enRetakeTest.FirstTimeSchdule;

        enum enMode { AddNewAppoinment = 1 , UpdateAppoinment = 2 }; 

        enMode _Mode = enMode.AddNewAppoinment;
        public ucAddNewTest()
        {
            InitializeComponent();
        }

        void _SetForm()
        {
            switch (_TestTypeID)
            {
                case clsTestTypes.enTestType.eVisonTest:
                    pictureBox1.Image = Resources.Vision_Test_32;
                    lbTitle.Text = "Vsion Test";
                    break;

                case clsTestTypes.enTestType.eWrittenTest:
                    pictureBox1.Image = Resources.Written_Test_32;
                    lbTitle.Text = "Writeen Test";
                    break;

                case clsTestTypes.enTestType.eStreetTest:
                    pictureBox1.Image = Resources.Street_Test_32;
                    lbTitle.Text = "Street Test";
                    break;
            }
        }



        public void LoadAddEditNewTest(int LocalApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            _SetForm();

            _LocalApplicationID = LocalApplicationID;
            _TestTypeID = TestTypeID;
            _TestAppointments = clsTestAppointments.FindTestByLocalApplicationID(LocalApplicationID);
            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.
                FindApplicationByLocalApplicationID(_LocalApplicationID);

            if (_LocalDrivingLicenseApplications == null)
            {
                MessageBox.Show("This Local application doesn't exsist",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (clsTestAppointments.GetPassedTestCount(_LocalApplicationID) > 0)
                ReTakeTestSchdule = enRetakeTest.FirstTimeSchdule; 
            else
                ReTakeTestSchdule = enRetakeTest.ReTakeTestSchdule;


            if (ReTakeTestSchdule == enRetakeTest.ReTakeTestSchdule)
            {
                gbReTakeTest.Enabled = true;

                lbRetakeApplicationFee.Text =
                    clsApplicationTypes.FindApplicationByApplicationTypeID((byte)
                   clsApplications.enApplicationType.eRetakeTest).ApplicationFees.ToString();

                decimal Total = decimal.Parse(lbRetakeApplicationFee.Text) +
                     decimal.Parse(lbFee.Text);
                lbTotalFee.Text = Total.ToString();
            }


            if (_Mode == enMode.UpdateAppoinment)
            {
                lbFee.Text = clsTestTypes.FindTestTypeID((int)_TestTypeID).TestTypeFees.ToString();
                dateTimePicker1.MinDate = DateTime.Now;
                lbReTakeTestApplication.Text = "N/A";

                _TestAppointments = new clsTestAppointments();

            }
            else
                _LoadAppoinmentData();
                   




        }


        
        void _LoadAppoinmentData()
        {

            lbDriverLocalID.Text = _LocalApplicationID.ToString();
            lbApplicantName.Text = clsPeople.Find(
                _LocalDrivingLicenseApplications.ApplicantPersonID).FullName;
            lbLicenseName.Text = _LocalDrivingLicenseApplications.LicenseClasses.ClassName;
            lbFee.Text = clsTestTypes.FindTestTypeID((int)_TestTypeID).TestTypeFees.ToString();
            lbTrial.Text = clsTestAppointments.GetTestTrial(_LocalApplicationID, (byte)_TestTypeID).ToString();

        }



        bool _HandleReTakeTest()
        {
 
                clsApplications Application;

                Application = new clsApplications();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplications.ApplicantPersonID;
                Application.ApplicationDate = dateTimePicker1.Value;
                Application.ApplicationStatus = clsApplications.enStatus.eCompleted;
                Application.ApplicationTypeID = (int)clsApplications.enApplicationType.eRetakeTest;
                Application.CreatedByUserID = clsCurrentUser.CurrentUser.UserID;
                Application.PaidFees = clsApplicationTypes.FindApplicationByApplicationTypeID(
                    (int)clsApplications.enApplicationType.eRetakeTest).ApplicationFees;

                if (!Application.Save())
                {
                    MessageBox.Show("ReTake Application Doesn't Saved", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                _TestAppointments.RetakeTest = Application.ApplicationID;
                _TestAppointments.Save();
            

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!_HandleReTakeTest())
                return;

            _TestAppointments = new clsTestAppointments();

            _TestAppointments.PaidFees = decimal.Parse(lbFee.Text.Trim());
            _TestAppointments.LocalDrivingLicenseApplicationID = _LocalApplicationID;
            _TestAppointments.AppointmentDate = dateTimePicker1.Value;
            _TestAppointments.TestTypeID =(byte) _TestTypeID;
            _TestAppointments.CreatedByUserID = clsCurrentUser.CurrentUser.UserID;

            if (RetakeTestID != -1)
                _TestAppointments.RetakeTest = RetakeTestID;

            if (_TestAppointments.Save())
            {
                MessageBox.Show("Test Appoinmente Saved Succefully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Test Appoinmente Saved Falid", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }
    }
}
