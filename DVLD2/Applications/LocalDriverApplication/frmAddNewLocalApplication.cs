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
    public partial class frmAddNewLocalApplication : Form
    {
        clsLocalDrivingLicenseApplications LocalApplication; 

        enum enMode { AddNewLocalDriverApplication , UpdateLocalDriverApplication};

        enMode Mode;

        int _LocalDriverApplicationID = 0; 
        public frmAddNewLocalApplication()
        {
            InitializeComponent();

            Mode = enMode.AddNewLocalDriverApplication; 
        }
        public frmAddNewLocalApplication(int LocalDriverApplicationID)
        {
            InitializeComponent();

            Mode = enMode.UpdateLocalDriverApplication;

            _LocalDriverApplicationID = LocalDriverApplicationID;
        }

        void FillLicenseClasses()
        {
            DataTable dtLicenseClasses = clsLicenseClasses.GetAllLicenseClasses();

            foreach (DataRow dr in dtLicenseClasses.Rows)
            {
                cbLicenseClassess.Items.Add(dr["ClassName"]);
            }
        }

        void SetDefalutValue()
        {
            FillLicenseClasses();

            if (Mode == enMode.AddNewLocalDriverApplication)
            {
                LocalApplication = new clsLocalDrivingLicenseApplications();
                lbTitle.Text = "Add New local Driver Application";
                this.Text = "Add New local Driver Application";

                btNext.Enabled = false;
                btSave.Enabled = false;
                tbApplicationnfo.Enabled = false;

                lbApplicationDate.Text = DateTime.Now.ToShortDateString();
                lbDriverLocalApplication.Text = "[????]";
                lbApplicationFee.Text = clsApplicationTypes.FindApplicationByApplicationTypeID(
                    (int)clsApplications.enApplicationType.eAddNewLocalApplication)
                    .ApplicationFees.ToString();
                lbCreatedBy.Text = clsCurrentUser.CurrentUser.UserName;
                cbLicenseClassess.SelectedIndex = 1;
            }
            else
            {
                lbTitle.Text = "Update local Driver Application";
                this.Text = "Update local Driver Application";

                btNext.Enabled = true;
                btSave.Enabled = true;
                tbApplicationnfo.Enabled = true;
            }
           
        }

        void _Load()
        {
            LocalApplication = clsLocalDrivingLicenseApplications
                .FindApplicationByLocalApplicationID(_LocalDriverApplicationID);


            ucUserInfoWithFilter1._LoadPersonInfoByPersonID(LocalApplication.ApplicantPersonID);
            lbDriverLocalApplication.Text = _LocalDriverApplicationID.ToString();
            lbApplicationDate.Text = LocalApplication.ApplicationDate.ToString();
            cbLicenseClassess.SelectedItem = LocalApplication.LicenseClasses.ClassName;
            lbApplicationFee.Text = LocalApplication.PaidFees.ToString();
            lbCreatedBy.Text = clsUser.FindByPersonID(LocalApplication.ApplicantPersonID).UserName;
        }

        private void frmAddNewLocalApplication_Load(object sender, EventArgs e)
        {
            SetDefalutValue();

            if (Mode == enMode.UpdateLocalDriverApplication)
                _Load();
        }

        private void ucUserInfoWithFilter1_OnPersonSelected(int obj)
        {
            if (Mode == enMode.AddNewLocalDriverApplication)
            {
                btNext.Enabled = true;
                btSave.Enabled = true;
                tbApplicationnfo.Enabled = true;
            }
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
           
            tabControl.SelectedIndex = 1; 
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = clsLicenseClasses.FindLicenseByLicenseClassName(
                cbLicenseClassess.SelectedItem.ToString()).LicenseClassID;
            int PersonID = ucUserInfoWithFilter1.PersonID;

            if (clsLocalDrivingLicenseApplications.CheckPersonHasApplcation(PersonID
                , LicenseClassID) && Mode == enMode.AddNewLocalDriverApplication)
            {
                MessageBox.Show("Person has active application with this class" , "Error" , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }


            LocalApplication.ApplicationStatus = clsApplications.enStatus.eNew;
            LocalApplication.ApplicantPersonID = PersonID;
            LocalApplication.ApplicationDate = Convert.ToDateTime(lbApplicationDate.Text);
            LocalApplication.PaidFees = clsApplicationTypes.FindApplicationByApplicationTypeID
                ( (int)clsApplications.enApplicationType.eAddNewLocalApplication).ApplicationFees;
            LocalApplication.LicenseClassID = clsLicenseClasses.FindLicenseByLicenseClassName
                (cbLicenseClassess.SelectedItem.ToString()).LicenseClassID;
            LocalApplication.CreatedByUserID = clsCurrentUser.CurrentUser.UserID;
            LocalApplication.ApplicationTypeID = clsApplicationTypes.FindApplicationByApplicationTypeID((int)
                clsApplications.enApplicationType.eAddNewLocalApplication).ApplicationTypeID; 

            if (LocalApplication.Save())
            {
                lbDriverLocalApplication.Text = LocalApplication.LocalDrivingLicenseApplicationID.ToString();
                Mode = enMode.UpdateLocalDriverApplication; 
                MessageBox.Show("Application Saved Successfully", "Done", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return; 
            }
            else
            {
                MessageBox.Show("Application Saved Falid", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return; 
            }

        }
    }
}
