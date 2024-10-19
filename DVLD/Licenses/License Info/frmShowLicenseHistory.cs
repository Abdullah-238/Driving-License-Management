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

namespace DVLD2.Licenses
{
    public partial class frmShowLicenseHistory : Form
    {

        int _LicenseID = 0;
        public frmShowLicenseHistory(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
        }

        void _LoadInternationalLicense()
        {
        

            DataTable _dtAllInternationalLicense =
                clsInternationalLicense.GetAllInternationalLicenes
                (_LicenseID);

            dgvInternationalLicenses.DataSource = _dtAllInternationalLicense;

            if (dgvInternationalLicenses.RowCount > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "IN.L.ID";
                dgvInternationalLicenses.Columns[0].Width = 40;

                dgvInternationalLicenses.Columns[1].HeaderText = "AP.ID";
                dgvInternationalLicenses.Columns[1].Width = 40;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 150;

                dgvInternationalLicenses.Columns[3].HeaderText = "Local License";
                dgvInternationalLicenses.Columns[3].Width = 100;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 100;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 80;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 80;

                lbNumbersOfLicenseInternation.Text = dgvInternationalLicenses.RowCount.ToString();
            }
        }

        void _LoadLocalLicense()
        {
            int PersonID = clsDriver.FindDriverByDriverID
                (clsLicense.FindByLicenseID(_LicenseID).DriverID).PersonID;

            DataTable _dtAllLocalLicense =
               clsLicense.GetAllLicensesByPersonID(PersonID);

            dgvLocalLicenses.DataSource = _dtAllLocalLicense;

            if (dgvLocalLicenses.RowCount > 0)
            {   
                dgvLocalLicenses.Columns[0].HeaderText = "License ID";
                dgvLocalLicenses.Columns[0].Width = 40;
 
                dgvLocalLicenses.Columns[1].HeaderText = "AP.ID";
                dgvLocalLicenses.Columns[1].Width = 40;
            
                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 150;
     
                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 100;
              
                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 80;
          
                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 80;

                lbLocalLicense.Text = dgvLocalLicenses.RowCount.ToString();
            }
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            ucLicense1._LoadLicenseInfo(_LicenseID);

            _LoadLocalLicense();

            _LoadInternationalLicense();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbNumbersOfLicense_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
