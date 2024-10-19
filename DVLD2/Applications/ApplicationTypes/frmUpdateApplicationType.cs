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

namespace DVLD2.ApplicationTypes
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationTypes _ApplicationTypes;

        int _ApplicationID = 0;
        public frmUpdateApplicationType(int ApplicationID)
        {
            InitializeComponent();

            _ApplicationID = ApplicationID;
        }


        void _Load()
        {
            _ApplicationTypes = clsApplicationTypes.FindApplicationByApplicationTypeID(_ApplicationID);

            lbApplicationID.Text = _ApplicationID.ToString();

            txTitle.Text = _ApplicationTypes.ApplicationTypeTitle;

            txFee.Text = _ApplicationTypes.ApplicationFees.ToString();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _ApplicationTypes.ApplicationFees = decimal.Parse(txFee.Text);
            _ApplicationTypes.ApplicationTypeTitle = txTitle.Text;
            

            if (_ApplicationTypes.Update())
            {
                MessageBox.Show("Application Type Updated succefully", "Done");
            }
            else
            {
                MessageBox.Show("Application Type Updated Faild", "Erorr");
            }


        }

        private void txFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
