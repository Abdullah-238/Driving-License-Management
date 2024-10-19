using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD2
{
    public partial class frmPeople : Form
    {
      static DataTable _dtAllPeople = clsPeople.GetPeople();
      static DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNO",
          "FullName",
            "Gender", "DateOfBirth", "CountryName", "Phone", "Email");
        public frmPeople()
        {
            InitializeComponent();
        }

        private void _RefreashList()
        {
             _dtAllPeople = clsPeople.GetPeople();
             _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNO", "FullName",
                "Gender","DateOfBirth", "CountryName", "Phone", "Email");

            dgvAllPeople.DataSource = _dtPeople;
            dgvAllPeople.RowCount.ToString();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            dgvAllPeople.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0; 

            if (dgvAllPeople.RowCount > 0 )
            {
                dgvAllPeople.Columns[0].HeaderText = "Person ID";
                dgvAllPeople.Columns[0].Width = 50;

                dgvAllPeople.Columns[1].HeaderText = "National NO";
                dgvAllPeople.Columns[1].Width = 50;

                dgvAllPeople.Columns[2].HeaderText = "Full Name";
                dgvAllPeople.Columns[2].Width = 220;

                dgvAllPeople.Columns[3].HeaderText = "Gender";
                dgvAllPeople.Columns[3].Width = 50;

                dgvAllPeople.Columns[4].HeaderText = "Date Of Birth";
                dgvAllPeople.Columns[4].Width = 100;

                dgvAllPeople.Columns[5].HeaderText = "Country";
                dgvAllPeople.Columns[5].Width = 70;

                dgvAllPeople.Columns[6].HeaderText = "Phone";
                dgvAllPeople.Columns[6].Width = 120;

                dgvAllPeople.Columns[7].HeaderText = "Email";
                dgvAllPeople.Columns[7].Width = 120;
            }

            lbNumbersOfPeople.Text = dgvAllPeople.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FilterValue = "";

            switch(cbFilter.Text)
            {
                case "Person ID":
                    FilterValue = "PersonID";
                    break;
                case "Gender":
                    FilterValue = "Gender";
                    break;
                case "Full Name":
                    FilterValue = "FullName";
                    break;
                case "Phone":
                    FilterValue = "Phone";
                    break;
                case "Country":
                    FilterValue = "CountryName";
                    break;
                case "Email":
                    FilterValue = "Email";
                    break;
                default:
                    FilterValue = "None";
                    break;
            }

            if (FilterValue == "None" || txValue.Text.Trim() == "")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbNumbersOfPeople.Text = dgvAllPeople.RowCount.ToString();
                return;
            }

            if (FilterValue == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterValue, txValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterValue, txValue.Text.Trim());


            lbNumbersOfPeople.Text = dgvAllPeople.RowCount.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txValue.Visible = false;
            }
            else
            {
                txValue.Visible = true;
            }
        }

        private void txValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 5)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson addUpdatePerson = new frmAddUpdatePerson();

            addUpdatePerson.ShowDialog();

            _RefreashList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;

            frmAddUpdatePerson updatePerson = new frmAddUpdatePerson(PersonID);

            updatePerson.ShowDialog();

            _RefreashList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson addUpdatePerson = new frmAddUpdatePerson();

            addUpdatePerson.ShowDialog();

            _RefreashList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("are you sure want to delete this person ?" 
                ,"Warining" , MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                if (clsPeople.Delete(PersonID))
                {
                    MessageBox.Show("Person deleted succefully", "Done");
                }
                else
                {
                    MessageBox.Show("Person deleted Faild", "Done");
                }
            }
            _RefreashList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Feature not implmented yet", "Done");
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this Feature not implmented yet", "Done");
        }

        private void showDetilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;

            frmShowPersonInfo PersonInfo = new frmShowPersonInfo(PersonID);

            PersonInfo.ShowDialog();

        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
