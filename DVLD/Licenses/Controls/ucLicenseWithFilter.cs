using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2.Licenses
{
    public partial class ucLicenseWithFilter : UserControl
    {

        public event Action<int> OnLicenseSelected; 

        protected virtual void PersonSelected (int Obs)
        {
            Action<int> handler = OnLicenseSelected;


        }

        int _LicenseID = 0; 

        public ucLicenseWithFilter()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
        }

        void _Load(string Search)
        {
            _LicenseID = int.Parse(Search);

            ucLicense1._LoadLicenseInfo(LicenseID);

            if (OnLicenseSelected != null)
            {
                OnLicenseSelected(_LicenseID);
            }

        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txSearch.Text != string.Empty)
            _Load(txSearch.Text);
        }
    }
}
