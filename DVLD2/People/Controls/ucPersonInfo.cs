using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2
{
    public partial class ucPersonInfo : UserControl
    {

        int _PersonID = 0;

        clsPeople _Person;

        public ucPersonInfo()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }

        public void _LoadPersonInfo(int PersonID)
        {
            _PersonID = PersonID;

            _Person = clsPeople.Find(PersonID);

            if (_Person == null )
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = "
                    + PersonID.ToString(), "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }
          
                FillPersonInfo();
        }

        public void _LoadPersonInfo(string NationalNo)
        {

            _Person = clsPeople.Find(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = "
                    + NationalNo.ToString(), "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            FillPersonInfo();
        }


        void FillPersonInfo()
        {
            groupBox1.Enabled = true; 
            lbPersonID.Text = _PersonID.ToString();
            lbName.Text = _Person.FullName;
            lbNationalNo.Text = _Person.NationalNo;
            lbDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lbGender.Text = (_Person.Gendor == 0 ? "Male" : "Female");
            lbEmail.Text = _Person.Email;
            lbPhone.Text = _Person.Phone;
            lbAddress.Text = _Person.Address;
            lbCountry.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;
            LoadPersonImage();
        }


        public void ResetPersonInfo()
        {
            lbPersonID.Text = "[???]"; 
            lbName.Text = "[???]";
            lbNationalNo.Text = "[???]";
            lbDateOfBirth.Text = "[???]";
            lbGender.Text = "[???]";
            lbEmail.Text = "[???]";
            lbPhone.Text = "[???]";
            lbAddress.Text = "[???]";
            lbCountry.Text = "[???]";

          
        }

        void LoadPersonImage()
        {

            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
            if (File.Exists(ImagePath))
            {
                pcPersonImage.Load(ImagePath);
            }
            else
            {
                MessageBox.Show("Image with path " + ImagePath + " not exists");
            }

           
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson(_PersonID);

            frmAddUpdatePerson.ShowDialog();
        }

      
    }
}
