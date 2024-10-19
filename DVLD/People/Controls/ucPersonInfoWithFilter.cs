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

namespace DVLD2.Users
{
    public partial class ucPersonInfoWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        int _PersonID = 0;

        public ucPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return _PersonID; }
        }

        public void _LoadPersonInfoByPersonID(int PersonID)
        {     
                _PersonID = PersonID;

                ucPersonInfo1.Enabled = true;
                ucPersonInfo1._LoadPersonInfo(_PersonID);
        }

        public void FindNow()
        {
            switch(cbSearchBy.Text)
            {
                case "Person ID" :
                    ucPersonInfo1._LoadPersonInfo(int.Parse(txSearch.Text));
                    break;

                case "National No":
                    ucPersonInfo1._LoadPersonInfo(int.Parse(txSearch.Text));
                    break;

                default:
                    break; 
            }

            if (OnPersonSelected != null)
            {
                OnPersonSelected(ucPersonInfo1.PersonID);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            FindNow();

        }


        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();

            frmAddUpdatePerson.DataBack += DataBackEvent; 

            frmAddUpdatePerson.ShowDialog();
        }


        void DataBackEvent (object sender , int PersonID)
        {
            cbSearchBy.SelectedIndex = 1;
            txSearch.Text = PersonID.ToString();
            ucPersonInfo1._LoadPersonInfo(PersonID);

        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSearchBy.SelectedIndex == 1)
            {
                txSearch.Text = "";
            }
            else
            {
                txSearch.Text = "";
            }
        }

        private void txSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSearchBy.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
