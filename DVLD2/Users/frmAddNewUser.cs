using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2.Users
{
    public partial class frmAddNewUser : Form
    {
        int _PersonID = 0;

        clsUser _User; 

        enum enMode { AddNewUser , UpdateUser };

        enMode _Mode;
        public frmAddNewUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNewUser;  
        }

        public frmAddNewUser(int UserID)
        {
            InitializeComponent();

            _PersonID = clsUser.FindUserByUserID(UserID).PersonID;

            _Mode = enMode.UpdateUser;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();

            frmAddUpdatePerson.ShowDialog();
        }

    
        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            _Load();
        }

       void _Load()
        {

            if (_Mode == enMode.AddNewUser)
            {
                _User = new clsUser();
                return;
            }

            this.lbTitle.Text = "Update User Info";


            _User = clsUser.FindByPersonID(_PersonID);
            ucUserInfoWithFilter1._LoadPersonInfoByPersonID(_PersonID);
            lbUserID.Text = _User.UserID.ToString();
            txUserName.Text = _User.UserName;
            if (_User.IsActive)
                ckIsActive.Checked = true;
            else 
                ckIsActive.Checked = false;

        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (clsUser.isUserFoundByUserName(txUserName.Text))
            {
                errorProvider1.SetError(txUserName,"This user name is exsist , please enter anthor one");
            }
            else
            {
                errorProvider1.SetError(txUserName, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _PersonID = ucUserInfoWithFilter1.PersonID; 

            if (_PersonID == 0)
            {
                MessageBox.Show("Please select a person before contuine", "Error");
                return;
            }

            if (clsUser.isUserFoundByPersonID(_PersonID))
            {
                MessageBox.Show("This person has User account please enter anthor person", "Error");
                return; 
            }

            tabControl1.SelectedIndex = 1;
        }
       
        private void Check_Vlidate(object sender, CancelEventArgs e)
        {
            TextBox tx = (TextBox)sender;

            if (string.IsNullOrEmpty(tx.Text))
            {
                errorProvider1.SetError(tx, "this valid should not be empty");
            }
            else
            {
                errorProvider1.SetError(tx, "");
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required faildes", "Error");
                return;
            }
            
            if (_Mode == enMode.AddNewUser)
            {
                if (txPassword.Text != txConfrimPassword.Text || txPassword.Text == string.Empty)
                {
                    MessageBox.Show("Password does'nt match please check", "Erorr");
                    return;
                }
            }

            _User.PersonID = _PersonID;
            _User.UserName = txUserName.Text;
            _User.Password = txPassword.Text;
            _User.IsActive = ckIsActive.Checked; 
          
               
            if (_User.Save())
            {
                MessageBox.Show("Data saved succesfully", "Done");
                _Mode = enMode.UpdateUser;
                _Load();
            }
            else
            {
                MessageBox.Show("Data saved Faild", "Error");
            }


        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
