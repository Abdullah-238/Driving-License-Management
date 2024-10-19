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

namespace DVLD2.Test_Types
{
    public partial class frmTestTypes : Form
    {
        static DataTable _dtAllTestTypes = clsTestTypes.GetAllTestTypes();

        static DataTable _dtTestTypes =
            _dtAllTestTypes.DefaultView.ToTable(false, "TestTypeID",
                "TestTypeTitle", "TestTypeDescription", "TestTypeFees");

        public frmTestTypes()
        {
            InitializeComponent();
        }

        void _Load()
        {
            dgvAllTestsTypes.DataSource = _dtTestTypes;

            if (dgvAllTestsTypes.RowCount > 0)
            {
                dgvAllTestsTypes.Columns[0].HeaderText = "ID";
                dgvAllTestsTypes.Columns[0].Width = 70;

                dgvAllTestsTypes.Columns[1].HeaderText = "Title";
                dgvAllTestsTypes.Columns[1].Width = 150;

                dgvAllTestsTypes.Columns[2].HeaderText = "Description";
                dgvAllTestsTypes.Columns[2].Width = 300;

                dgvAllTestsTypes.Columns[3].HeaderText = "Fee";
                dgvAllTestsTypes.Columns[3].Width = 100;

            }

            lbNumbersOfTestTypes.Text = dgvAllTestsTypes.RowCount.ToString();

        }

        private void _RefreashList()
        {
            DataTable _dtAllTestTypes = clsTestTypes.GetAllTestTypes();

            DataTable _dtTestTypes =
                _dtAllTestTypes.DefaultView.ToTable(false, "TestTypeID", "TestTypeTitle", "TestTypeDescription", "TestTypeFees");

            dgvAllTestsTypes.DataSource = _dtTestTypes;

            lbNumbersOfTestTypes.Text = dgvAllTestsTypes.RowCount.ToString();
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dgvAllTestsTypes.CurrentRow.Cells[0].Value;

            frmUpdateTest UpdateTest = new frmUpdateTest(TestTypeID);

            UpdateTest.Show();

            _RefreashList();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _Load();
        }
    }
}
