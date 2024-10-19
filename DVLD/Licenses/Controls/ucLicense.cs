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
    public partial class ucLicense : UserControl
    {
        public ucLicense()
        {
            InitializeComponent();
        }

        clsLicense _License;

        int _LicenseID = 0;
        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
        }

        public void _LoadLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;

            _License = clsLicense.FindByLicenseID(LicenseID);

            if (_License == null)
            {
                MessageBox.Show("License deosn't found Please try again", "Erorr");
                return;
            }

            int PersonID = clsDriver.FindDriverByDriverID(_License.DriverID).PersonID;
            lbClass.Text = clsLicenseClasses.FindLicenseByLicenseClassID(_License.LicenseClass).ClassName;
            lbName.Text = clsPeople.Find(PersonID).FullName;
            lbLicenseID.Text = _License.LicenseID.ToString();
            lbNationalNo.Text = clsPeople.Find(PersonID).NationalNo;

            if (clsPeople.Find(PersonID).ImagePath != string.Empty &&
                clsPeople.Find(PersonID).ImagePath != null)
                pcPersonImage.Load(clsPeople.Find(PersonID).ImagePath);



            if (clsPeople.Find(PersonID).Gendor == 1)
                lbGender.Text = "Male";
            else
                lbGender.Text = "Female";

            lbIssueDate.Text = _License.IssueDate.ToString();
            lbIssueReason.Text = _License.IssueReasonText; 
            lbNote.Text = _License.Notes.ToString();

            if (_License.IsActive)
                lbIsActive.Text = "Yes";
            else
                lbIsActive.Text = "No";

            lbDateOfBirth.Text = clsPeople.Find(PersonID).DateOfBirth.ToString();
            lbDriverID.Text = _License.DriverID.ToString();
            lbExpirationDate.Text = _License.ExpirationDate.ToString();


            if (clsDetainedLicenses.IsLicenseDetained(_LicenseID))
                lbIsDetained.Text = "Yes";
            else
                lbIsDetained.Text = "No";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
