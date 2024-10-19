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

namespace DVLD2.Test_Types
{
    public partial class frmUpdateTest : Form
    {
        clsTestTypes _TestTypes;

        int _TestTypeID = 0;
        public frmUpdateTest(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID; 
        }

        void _Load()
        {
            _TestTypes = clsTestTypes.FindTestTypeID(_TestTypeID);

            lbTestTypeID.Text = _TestTypeID.ToString();

            txTitle.Text = _TestTypes.TestTypeTitle;

            txFee.Text = _TestTypes.TestTypeFees.ToString();

            txDescrapation.Text = _TestTypes.TestTypeDescription;

        }


        private void frmUpdateTest_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _TestTypes.TestTypeFees = decimal.Parse(txFee.Text);
            _TestTypes.TestTypeTitle = txTitle.Text;
            _TestTypes.TestTypeDescription = txDescrapation.Text;


            if (_TestTypes.UpdateTest())
            {
                MessageBox.Show("Test Type Updated succefully", "Done");
            }
            else
            {
                MessageBox.Show("Test Type Updated Faild", "Erorr");
            }
        }

        private void txFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
