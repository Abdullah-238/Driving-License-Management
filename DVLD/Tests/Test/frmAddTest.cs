using DVLD2.Properties;
using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLV2_BusinessLogic.clsTestTypes;

namespace DVLD2.LocalDriverApplication.Test
{
    public partial class frmAddTest : Form
    {
        int _LocalApplicationID = 0;
        clsTestTypes.enTestType _TestTypeID ;
    
        public frmAddTest(int LocalApplicationID , clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();

            _LocalApplicationID = LocalApplicationID;

            _TestTypeID = TestTypeID;
        }

        private void frmAddTest_Load(object sender, EventArgs e)
        {
            ucAddNewTest1.LoadAddEditNewTest(_LocalApplicationID, _TestTypeID);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucAddNewTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
