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

namespace DVLD2.LocalDriverApplication.Test
{
    public partial class frmTestAppointment : Form
    {
        int _LocalApplicationID = 0;

        clsTestTypes.enTestType _TestType ; 
        public frmTestAppointment(int LocalApplicationID , clsTestTypes.enTestType TestType)
        {
            InitializeComponent();

            _LocalApplicationID = LocalApplicationID;

            _TestType = TestType;
        }
        private void _RefreashList()
        {
            dgvAllTests.DataSource =
            clsTestAppointments.GetAllTestAppoinment(_LocalApplicationID);

            lbNumbersOfAppoinment.Text = dgvAllTests.RowCount.ToString();
        }

        void _Load()
        {
            switch(_TestType)
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

        private void frmTestAppointment_Load(object sender, EventArgs e)
        {
            _Load();

            ucApplicationInfo1.LoadApplicationInfo(_LocalApplicationID);

            dgvAllTests.DataSource =
            clsTestAppointments.GetAllTestAppoinment(_LocalApplicationID);

            if (dgvAllTests.Rows.Count > 0)
            {
                dgvAllTests.Columns[0].Width = 150;

                dgvAllTests.Columns[1].Width = 170;

                dgvAllTests.Columns[2].Width = 120;

                dgvAllTests.Columns[3].Width = 110;

              
            }

            lbNumbersOfAppoinment.Text = dgvAllTests.RowCount.ToString();


        }

        private void btAddNewApplication_Click(object sender, EventArgs e)
        {

            if (clsTestAppointments.isHasActiveAppoinment(_LocalApplicationID))
            {
                MessageBox.Show("This person has active appoinment","Error",MessageBoxButtons.OK
                    ,MessageBoxIcon.Error );
                return;
            }

            if (clsTestAppointments.DoesPassedTest(_LocalApplicationID,(byte)_TestType))
            {
                MessageBox.Show("This person has Passed this test", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            frmAddTest AddTest = new frmAddTest(_LocalApplicationID,_TestType);

            AddTest.ShowDialog();

            _RefreashList();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestApponimentID = (int)dgvAllTests.CurrentRow.Cells[0].Value;  

            frmTakeTest takeTest = new frmTakeTest(_LocalApplicationID, TestApponimentID);

            takeTest.ShowDialog();

            _RefreashList();
        }
    }
}
