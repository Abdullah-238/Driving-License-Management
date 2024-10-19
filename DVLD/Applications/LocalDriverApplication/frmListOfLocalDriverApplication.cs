using DVLD2.LocalDriverApplication.Test;
using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD2.LocalDriverApplication
{
    public partial class frmListOfLocalDriverApplication : Form
    {
        static DataTable _dtAllLocalApplications = clsLocalDrivingLicenseApplications.GetAllDrivingLocalLicenseApplication();
     
        public frmListOfLocalDriverApplication()
        {
            InitializeComponent();
        }

        private void _RefreashList()
        {
            _dtAllLocalApplications = clsLocalDrivingLicenseApplications.GetAllDrivingLocalLicenseApplication();

            dgvAllApplication.DataSource = _dtAllLocalApplications;
            lbNumbersOfApplications.Text = dgvAllApplication.RowCount.ToString();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListOfLocalDriverApplication_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; 

            dgvAllApplication.DataSource= _dtAllLocalApplications;

            if (dgvAllApplication.Rows.Count > 0 )
            {
                dgvAllApplication.Columns[0].HeaderText = "L.D.APP";
                dgvAllApplication.Columns[0].Width = 50;

                dgvAllApplication.Columns[1].HeaderText = "Driving Class";
                dgvAllApplication.Columns[1].Width = 250;

                dgvAllApplication.Columns[2].HeaderText = "National NO";
                dgvAllApplication.Columns[2].Width = 50;

                dgvAllApplication.Columns[3].HeaderText = "Full Name";
                dgvAllApplication.Columns[3].Width = 200;

                dgvAllApplication.Columns[4].HeaderText = "Application Date";
                dgvAllApplication.Columns[4].Width = 80;

                dgvAllApplication.Columns[5].HeaderText = "Passed Test";
                dgvAllApplication.Columns[5].Width = 50;

                dgvAllApplication.Columns[6].HeaderText = "Status";
                dgvAllApplication.Columns[6].Width = 80;
            }
            lbNumbersOfApplications.Text = dgvAllApplication.RowCount.ToString();
        }

        private void txValue_TextChanged(object sender, EventArgs e)
        {
        
            string FilterValue = "";

            switch (cbFilter.Text)
            {
                case "L.D.APP.ID":
                    FilterValue = "LocalDrivingLicenseApplicationID";
                    break;
                case "Full Name":
                    FilterValue = "FullName";
                    break;
                case "National NO":
                    FilterValue = "NationalNO";
                    break;
                case "Status":
                    FilterValue = "Status";
                    break;
                default:
                    FilterValue = "None";
                    break;
            }

            if (FilterValue == "None" || txValue.Text.Trim() == "")
            {
                _dtAllLocalApplications.DefaultView.RowFilter = "";
                lbNumbersOfApplications.Text = dgvAllApplication.RowCount.ToString();
                return;
            }

            if (FilterValue == "LocalDrivingLicenseApplicationID")
                _dtAllLocalApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterValue, txValue.Text.Trim());
            else
                _dtAllLocalApplications.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterValue, txValue.Text.Trim());

            lbNumbersOfApplications.Text = dgvAllApplication.RowCount.ToString();

        }

        private void btAddNewApplication_Click(object sender, EventArgs e)
        {
            frmAddNewLocalApplication localApplication = new frmAddNewLocalApplication();

            localApplication.ShowDialog();

            _RefreashList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txValue.Visible = false;
            }
            else
            {
                txValue.Visible = true;
            }
        }

        private void txValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 4)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LocalAppID = (int)dgvAllApplication.CurrentRow.Cells[0].Value;

            int PassedTest = (int)dgvAllApplication.CurrentRow.Cells[5].Value;

            bool VisionTest = clsTestAppointments.DoesPassedTest(LocalAppID, (byte)clsTestTypes.enTestType.eVisonTest);
            bool WrittenTest = clsTestAppointments.DoesPassedTest(LocalAppID, (byte)clsTestTypes.enTestType.eWrittenTest);
            bool StreetTest = clsTestAppointments.DoesPassedTest(LocalAppID, (byte)clsTestTypes.enTestType.eStreetTest);

            sechduleTestToolStripMenuItem.Enabled = (PassedTest != 3);
            issueDriverLicenseFirstTimeToolStripMenuItem.Enabled = ((PassedTest == 3)
                && !clsLicense.HasActiveLicense(clsLocalDrivingLicenseApplications.
                FindApplicationByLocalApplicationID(LocalAppID).ApplicationID));

            editApplicationToolStripMenuItem.Enabled = !VisionTest; 
            deleteApplicationToolStripMenuItem.Enabled = !VisionTest;
            cancelApplicationToolStripMenuItem.Enabled = !StreetTest;

            if (contextMenuStrip1.Enabled)
            {
                sechduleVisonTestToolStripMenuItem.Enabled = !VisionTest;
                sechduleWrittenTestToolStripMenuItem.Enabled = VisionTest && !WrittenTest;
                sechduleStreetTestToolStripMenuItem.Enabled = VisionTest && WrittenTest && !StreetTest;
            }
        }

        private void TestType(clsTestTypes.enTestType TestTypeID)
        {
            int LocalAppID = (int)dgvAllApplication.CurrentRow.Cells[0].Value;

            frmTestAppointment testAppointment = new frmTestAppointment(LocalAppID, TestTypeID);

            testAppointment.ShowDialog();

            _RefreashList();
        }

        private void sechduleVisonTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType(clsTestTypes.enTestType.eVisonTest);
        }

        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType(clsTestTypes.enTestType.eWrittenTest);
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType(clsTestTypes.enTestType.eStreetTest);
        }

        private void issueDriverLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvAllApplication.CurrentRow.Cells[0].Value;

            frmIssueLicenseFirstTime frmIssueLicenseFirstTime
                = new frmIssueLicenseFirstTime(LocalAppID);

            frmIssueLicenseFirstTime.ShowDialog();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvAllApplication.CurrentRow.Cells[0].Value;

            frmAddNewLocalApplication localApplication =
                new frmAddNewLocalApplication(LocalAppID);

            localApplication.ShowDialog();

            _RefreashList();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvAllApplication.CurrentRow.Cells[0].Value;


            clsLocalDrivingLicenseApplications localDrivingLicenseApplications
                =  clsLocalDrivingLicenseApplications.
                FindApplicationByLocalApplicationID(LocalAppID);

            if (MessageBox.Show("Do you want to Delete this application" , "Done" ,
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (localDrivingLicenseApplications.Delete())
                {
                    MessageBox.Show("Application deleted Successfully", "Done",
                MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Application deleted Faild", "Error",
                MessageBoxButtons.OK);
            }


            

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvAllApplication.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplications localDrivingLicenseApplications
              = clsLocalDrivingLicenseApplications.
              FindApplicationByLocalApplicationID(LocalAppID);

            if (MessageBox.Show("Do you want to cancel this application", "Done",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsLocalDrivingLicenseApplications.CancelApplication(
                    localDrivingLicenseApplications.ApplicationID))
                {
                    MessageBox.Show("Application Cancel Successfully", "Done",
                MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Application Cancel Faild", "Error",
                    MessageBoxButtons.OK);
                }
            }
          
        }
    }
}
