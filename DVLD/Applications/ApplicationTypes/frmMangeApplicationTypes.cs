using DVLD2.ApplicationTypes;
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
    public partial class frmMangeApplicationTypes : Form
    {
        static DataTable _dtAllApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();

        static DataTable _dtApplicationsTypes = 
            _dtAllApplicationTypes.DefaultView.ToTable(false, "ApplicationTypeID", "ApplicationTypeTitle", "ApplicationFees");
        public frmMangeApplicationTypes()
        {
            InitializeComponent();
        }

        void _Load()
        {
            dgvAllApplicationTypes.DataSource = _dtApplicationsTypes;

            if (dgvAllApplicationTypes.RowCount > 0 )
            {
                dgvAllApplicationTypes.Columns[0].HeaderText = "ID";
                dgvAllApplicationTypes.Columns[0].Width = 70;

                dgvAllApplicationTypes.Columns[1].HeaderText = "Title";
                dgvAllApplicationTypes.Columns[1].Width = 250;

                dgvAllApplicationTypes.Columns[2].HeaderText = "Fee";
                dgvAllApplicationTypes.Columns[2].Width = 100;

            }

            lbNumbersOfApplicationTypes.Text = dgvAllApplicationTypes.RowCount.ToString();

        }

        private void _RefreashList()
        {
            DataTable dtAllApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();

            DataTable dtApplicationsTypes =
                dtAllApplicationTypes.DefaultView.ToTable(false, "ApplicationTypeID", "ApplicationTypeTitle", "ApplicationFees");

            dgvAllApplicationTypes.DataSource = dtApplicationsTypes;

            lbNumbersOfApplicationTypes.Text = dgvAllApplicationTypes.RowCount.ToString();
        }

        private void frmMangeApplicationTypes_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = (int)dgvAllApplicationTypes.CurrentRow.Cells[0].Value;

            frmUpdateApplicationType ApplicationType = new frmUpdateApplicationType(ApplicationTypeID);

            ApplicationType.ShowDialog();

            _RefreashList();
        }
    }
}
