using DVLD2.Licenses;
using DVLD2.Licenses.Detained_License;
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

namespace DVLD2.Detained_License
{
    public partial class frmDetinedLicenseList : Form
    {
        static DataTable _dtAllDetainedLicense = clsDetainedLicenses.GetDetainedLicenses();
        static DataTable _dtDetained = _dtAllDetainedLicense.DefaultView.ToTable(false, "DetainID", "LicenseID", "DetainDate",
                          "IsReleased", "FineFees", "ReleaseDate", "NationalNo", "FullName", "ReleaseApplicationID");
        public frmDetinedLicenseList()
        {
            InitializeComponent();
        }
        private void _RefreashList()
        {
            _dtAllDetainedLicense = clsDetainedLicenses.GetDetainedLicenses();
            _dtDetained = _dtAllDetainedLicense.DefaultView.ToTable(false, "DetainID", "LicenseID", "DetainDate",
                              "IsReleased", "FineFees", "ReleaseDate", "NationalNo", "FullName", "ReleaseApplicationID");

            dgvAllDetainedLicense.DataSource = _dtDetained;

            lbNumbersOfDetainedLicense.Text = dgvAllDetainedLicense.RowCount.ToString();
        }

        private void frmDetinedLicenseList_Load(object sender, EventArgs e)
        {
            dgvAllDetainedLicense.DataSource = _dtDetained;
            cbFilter.SelectedIndex = 0;

            if (dgvAllDetainedLicense.RowCount > 0)
            {
                dgvAllDetainedLicense.Columns[0].HeaderText = "D.ID";
                dgvAllDetainedLicense.Columns[0].Width = 70;

                dgvAllDetainedLicense.Columns[1].HeaderText = "L.ID";
                dgvAllDetainedLicense.Columns[1].Width = 70;
                
                dgvAllDetainedLicense.Columns[2].HeaderText = "D.Date";
                dgvAllDetainedLicense.Columns[2].Width = 250;
                
                dgvAllDetainedLicense.Columns[3].HeaderText = "Is Released";
                dgvAllDetainedLicense.Columns[3].Width = 100;
                
                dgvAllDetainedLicense.Columns[4].HeaderText = "Fine Fees";
                dgvAllDetainedLicense.Columns[4].Width = 70;

                dgvAllDetainedLicense.Columns[5].HeaderText = "Release Date";
                dgvAllDetainedLicense.Columns[5].Width = 70;

                dgvAllDetainedLicense.Columns[6].HeaderText = "N.No";
                dgvAllDetainedLicense.Columns[6].Width = 70;

                dgvAllDetainedLicense.Columns[7].HeaderText = "Name";
                dgvAllDetainedLicense.Columns[7].Width = 70;

                dgvAllDetainedLicense.Columns[8].HeaderText = "Release App.ID";
                dgvAllDetainedLicense.Columns[8].Width = 70;

            }

            lbNumbersOfDetainedLicense.Text = dgvAllDetainedLicense.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txValue_TextChanged(object sender, EventArgs e)
        {
            string FilterValue = "";

            switch (cbFilter.Text)
            {
                case "Detained ID":
                    FilterValue = "DetainID";
                    break;
                case "National NO":
                    FilterValue = "NationalNO";
                    break;
                case "Full Name":
                    FilterValue = "FullName";
                    break;
                case "Release Application ID":
                    FilterValue = "ReleaseApplicationID";
                    break;
                case "Is Realease":
                    FilterValue = "IsRealease";
                    break;
            }

            if (FilterValue == "None" || txValue.Text.Trim() == "")
            {
                _dtDetained.DefaultView.RowFilter = "";
                lbNumbersOfDetainedLicense.Text = dgvAllDetainedLicense.RowCount.ToString();
                return;
            }

            if (FilterValue == "DetainID" || FilterValue == "ReleaseApplicationID")
                _dtDetained.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterValue, txValue.Text.Trim());
            else
                _dtDetained.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterValue, txValue.Text.Trim());


            lbNumbersOfDetainedLicense.Text = dgvAllDetainedLicense.RowCount.ToString();

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColoumn = "IsReleased";

            string FilterValue = cbIsRealease.Text;

            switch (FilterValue)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
            {
                _dtDetained.DefaultView.RowFilter = "";
            }
            else
                _dtDetained.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColoumn, FilterValue);

            lbNumbersOfDetainedLicense.Text = dgvAllDetainedLicense.RowCount.ToString();
          
        }

        private void txValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 4)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0 || cbFilter.SelectedIndex == 5)
            {
                txValue.Visible = false;
            }
            else
            {
                txValue.Visible = true;
            }

            if (cbFilter.SelectedIndex == 5)
            {
                cbIsRealease.Visible = true;
            }
            else
            {
                cbIsRealease.Visible = false;
            }
        }

        private void showDetilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Row = dgvAllDetainedLicense.CurrentRow.Cells[6].Value.ToString();

            int PersonID = clsPeople.Find(Row).PersonID;

            frmShowPersonInfo PersonInfo = new frmShowPersonInfo(PersonID);

            PersonInfo.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLicenseInfo Licence = new frmLicenseInfo((int)dgvAllDetainedLicense.CurrentRow.Cells[1].Value);

            Licence.ShowDialog();   
        }

        private void btDetainedLicense_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frmDetinedLicenseList = new frmDetainedLicense();

            frmDetinedLicenseList.ShowDialog();

            _RefreashList();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory LicenseHistory = 
                new frmShowLicenseHistory((int)dgvAllDetainedLicense.CurrentRow.Cells[1].Value);

                LicenseHistory.ShowDialog();
        }

        private void btRelease_Click(object sender, EventArgs e)
        {
            frmRealeaseLicense realeaseLicense = new frmRealeaseLicense();

            realeaseLicense.ShowDialog();

            _RefreashList();
        }
    }
}
