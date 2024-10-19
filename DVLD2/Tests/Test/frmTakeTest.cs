using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2.LocalDriverApplication
{
    public partial class frmTakeTest : Form
    {
        int _LocalDriverApplicationID = 0;

        int _TestApponimentID = 0;
        public frmTakeTest(int LocalDriverApplicationID ,int TestApponimentID)
        {
            InitializeComponent();

            _LocalDriverApplicationID = LocalDriverApplicationID;

            _TestApponimentID = TestApponimentID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ucTakeTest1.LoadTakeTest(_LocalDriverApplicationID, _TestApponimentID); 
        }

        private void ucTakeTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
