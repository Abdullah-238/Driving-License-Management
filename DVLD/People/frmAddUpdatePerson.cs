using DVLD2.Global;
using DVLD2.Properties;
using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void  DataBackEventHandler (object sender, int PersonID);

        public DataBackEventHandler DataBack; 

        enum enMode { AddNewPerson, UpdatePerson };

        enMode _Mode;

        int _PersonID = 0;

        clsPeople _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNewPerson;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.UpdatePerson;

            _PersonID = PersonID;
        }

        void _FillCountryList()
        {
            DataTable dtCountry = clsCountries.GetCountires();

            foreach (DataRow dr in dtCountry.Rows)
            {
                cbCountry.Items.Add(dr["CountryName"]);
            }
            cbCountry.SelectedIndex = 149;
        }

        void _SetDefaultValue()
        {
            _FillCountryList();

            if (_Mode == enMode.AddNewPerson)
            {
                this.Text = "Add New Person";
                lbTitle.Text = "Add New Person";
                _Person = new clsPeople();
            }
            else
            {
                lbTitle.Text = "Update Person";
                this.Text = "Update Person";
            }

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            llRemoveImage.Visible = (pcPersonImage.ImageLocation != null);



            txFirstName.Text = "";
            txSecondName.Text = "";
            txThirdName.Text = "";
            txLastName.Text = "";
            txNationalNo.Text = "";

            rbFemale.Checked = true;

            txPhone.Text = "";
            txEmail.Text = "";

            txAddress.Text = "";

            


        }

        void _Load()
        {

            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with PersonID = " +
                   _PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbPersonID.Text = _PersonID.ToString();
            txFirstName.Text = _Person.FirstName;
            txSecondName.Text = _Person.SecondName;
            txThirdName.Text = _Person.ThirdName;
            txLastName.Text = _Person.LastName;
            txNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            txPhone.Text = _Person.Phone;
            txEmail.Text = _Person.Email;
            cbCountry.SelectedIndex = _Person.NationalityCountryID;
            txAddress.Text = _Person.Address;

            if (_Person.ImagePath != string.Empty && _Person.ImagePath != null)
                pcPersonImage.Load(_Person.ImagePath);
            else
                llRemoveImage.Visible = false;

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _SetDefaultValue();

            if (_Mode == enMode.UpdatePerson)
                _Load();
        }

        bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pcPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (pcPersonImage.ImageLocation != null)
                {

                    string SourceImageFile = pcPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pcPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required faildes", "Error");
                return;
            }


            if (!_HandlePersonImage())
                return;

            if (clsPeople.isPersonFoundByNationalNo(txNationalNo.Text) && _Mode == enMode.AddNewPerson)
            {
                MessageBox.Show("This National Number Is exist please enter anthor Number", "Error");
                return;

            }

            if (txPhone.Text.Length < 10)
            {
                MessageBox.Show("Please check of number phone", "Error");
                return;
            }

            _Person.FirstName = txFirstName.Text;
            _Person.SecondName = txSecondName.Text;
            _Person.ThirdName = txThirdName.Text;
            _Person.LastName = txLastName.Text;
            _Person.NationalNo =   txNationalNo.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (rbMale.Checked)
                _Person.Gendor = 1;
            if (rbFemale.Checked)
                _Person.Gendor = 0;
            _Person.Phone =  txPhone.Text;
            _Person.Email = txEmail.Text;
            _Person.NationalityCountryID = cbCountry.SelectedIndex;
            _Person.Address = txAddress.Text;

            if (pcPersonImage.ImageLocation != null)
                _Person.ImagePath = pcPersonImage.ImageLocation;
            else
                _Person.ImagePath = ""; 


            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Succefully", "Done");
                _PersonID = _Person.PersonID; 
                _Mode = enMode.UpdatePerson;
                _Load();

                DataBack?.Invoke(this, _PersonID);
            }
            else
            {
                MessageBox.Show("Data Saved Faild", "Done");
            }


        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
                pcPersonImage.Image = Resources.Female_512;
            else
                pcPersonImage.Image = Resources.Male_512;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pcPersonImage.ImageLocation != "")
            {
                pcPersonImage.Image = null; 

                llRemoveImage.Visible = false;
            }
            else
            {
                llRemoveImage.Visible = true;
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pcPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }

        }
   

        private void txPhone_KeyPress(object sender, KeyPressEventArgs e)
        {  
             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txNationalNo_TextChanged(object sender, EventArgs e)
        {
            if (clsPeople.isPersonFoundByNationalNo(txNationalNo.Text))
            {
                errorProvider1.SetError(txNationalNo, "This National No Is exist please enter anthor National No");
            }
            else
            {
                errorProvider1.SetError(txNationalNo, "");
            }
        }

        private void Check_Validate(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox) sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void Check_Email_Validting(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateEmail(txEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txEmail, "this email format not correct");
            }
            else
            {
                errorProvider1.SetError(txEmail, null);
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
