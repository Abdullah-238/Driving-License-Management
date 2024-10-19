using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD2
{
    public partial class frmShowPersonInfo : Form
    {
        int _PersonId = 0; 
        public frmShowPersonInfo(int PersonId)
        {
            InitializeComponent();

            _PersonId = PersonId;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ucPersonInfo1._LoadPersonInfo(_PersonId);
        }
    }
}
