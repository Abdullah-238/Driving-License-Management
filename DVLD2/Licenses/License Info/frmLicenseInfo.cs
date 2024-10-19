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
    public partial class frmLicenseInfo : Form
    {
        int _LicenseID = 0; 
        public frmLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
        }

        

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ucLicense1._LoadLicenseInfo(_LicenseID);
        }
    }
}
