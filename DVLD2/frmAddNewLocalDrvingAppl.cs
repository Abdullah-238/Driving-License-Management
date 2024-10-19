using DVLV2_BusinessLogic;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD2.Applications
{
    public partial class frmAddNewLocalDrvingAppl : Form
    {
        enum enMode { AddNewLocalApplication, UpdateLocalApplication };

        enMode _Mode = enMode.AddNewLocalApplication;

        clsLocalDrivingLicenseApplications _LocalDrivingApplication;

        int _LocalApplicationID = 0;

        private void _FillLicenseClassesInComoboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClasses.GetAllLicenseClasses();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }
        }


        public frmAddNewLocalDrvingAppl()
        {
            InitializeComponent();

            _Mode = enMode.AddNewLocalApplication;
        }
        public frmAddNewLocalDrvingAppl(int LocalApplicationID)
        {
            InitializeComponent();

            _LocalApplicationID = LocalApplicationID;

            _Mode = enMode.UpdateLocalApplication;
        }

        void ResetDefulatValues()
        {
            _FillLicenseClassesInComoboBox();

            if (_Mode == enMode.AddNewLocalApplication)
            {
                _LocalDrivingApplication = new clsLocalDrivingLicenseApplications();

                this.Text = "Add New Local Application";
                lbTitle.Text = "Add New Local Application";

                tbApplicationInfo.Enabled = false;

                lbDRApplicationID.Text = "[????]";
                lbDate.Text = DateTime.Now.ToShortDateString();
                cbLicenseClass.SelectedIndex = 0;
                lbApplicationFee.Text =
                    clsApplicationTypes.FindApplicationByApplicationTypeID(1).ApplicationFees.ToString();
                lbCreatedByUser.Text = clsCurrentUser.CurrentUser.UserName;
            }

            else
            {
                this.Text = "Update Local Application";
                lbTitle.Text = "Update Local Application";
            }


        }


        void _Load()
        {
            _LocalDrivingApplication =
                    clsLocalDrivingLicenseApplications.
                    FindApplicationByLocalApplicationID(_LocalApplicationID);

            lbDRApplicationID.Text = _LocalApplicationID.ToString();
            lbDate.Text = _LocalDrivingApplication.ApplicationDate.ToString();
            cbLicenseClass.SelectedItem =
                clsLicenseClasses.FindLicenseByLicenseClassID(_LocalDrivingApplication.LicenseClassID).ClassName;
            lbApplicationFee.Text = _LocalDrivingApplication.PaidFees.ToString();
            lbCreatedByUser.Text = clsUser.FindUserByUserID(_LocalDrivingApplication.CreatedByUserID).UserName;
            ucUserInfoWithFilter1._LoadPersonInfoByPersonID(_LocalDrivingApplication.ApplicantPersonID);
        }

        private void frmAddNewLocalDrvingAppl_Load(object sender, EventArgs e)
        {
            ResetDefulatValues();

            if (_Mode == enMode.UpdateLocalApplication)
            {
                _Load();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tbApplicationInfo.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            int LicenseID =
                clsLicenseClasses.FindLicenseByLicenseClassName((string)cbLicenseClass.SelectedItem).
                LicenseClassID;

            if (clsApplications.CheckPersonHasApplcation(ucUserInfoWithFilter1.PersonID, LicenseID))
            {
                MessageBox.Show("this user has already valid application", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            if (_Mode == enMode.AddNewLocalApplication)
            {
                _LocalDrivingApplication.ApplicationDate = DateTime.Now;
            }

            _LocalDrivingApplication.ApplicantPersonID = ucUserInfoWithFilter1.PersonID;
            _LocalDrivingApplication.ApplicationStatus = 1;
            _LocalDrivingApplication.PaidFees = Convert.ToDecimal(lbApplicationFee.Text);
            _LocalDrivingApplication.LicenseClassID = LicenseID;
            _LocalDrivingApplication.CreatedByUserID = clsCurrentUser.CurrentUser.UserID;
            _LocalDrivingApplication.ApplicationTypeID = 1;



            if (_LocalDrivingApplication.Save())
            {
                lbDRApplicationID.Text =
                    _LocalDrivingApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = enMode.UpdateLocalApplication;
                lbTitle.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddNewLocalDrvingAppl
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmAddNewLocalDrvingAppl";
            this.Load += new System.EventHandler(this.frmAddNewLocalDrvingAppl_Load_1);
            this.ResumeLayout(false);

        }

        private void frmAddNewLocalDrvingAppl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
