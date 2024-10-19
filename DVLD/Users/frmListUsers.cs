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
    public partial class frmListUsers : Form
    {
        static DataTable _dtAllUsers = clsUser.GetAllUsers();
        static DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false,"UserID", "PersonID",
                          "FullName", "UserName", "IsActive");
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _RefreashList()
        {
            DataTable dtAllUsers = clsUser.GetAllUsers();
            DataTable dtUsers = dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID",
                              "FullName", "UserName", "IsActive");

            dgvAllUsers.DataSource = dtUsers;

            lbNumbersOfUsers.Text = dgvAllUsers.RowCount.ToString();
        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            dgvAllUsers.DataSource = _dtUsers;
            cbFilter.SelectedIndex = 0;

            if (dgvAllUsers.RowCount > 0)
            {
                dgvAllUsers.Columns[0].HeaderText = "User ID";
                dgvAllUsers.Columns[0].Width = 70;

                dgvAllUsers.Columns[1].HeaderText = "Person ID";
                dgvAllUsers.Columns[1].Width = 70;

                dgvAllUsers.Columns[2].HeaderText = "Full Name";
                dgvAllUsers.Columns[2].Width = 250;

                dgvAllUsers.Columns[3].HeaderText = "User Name";
                dgvAllUsers.Columns[3].Width = 100;

                dgvAllUsers.Columns[4].HeaderText = "Is Active";
                dgvAllUsers.Columns[4].Width = 70;

            }

            lbNumbersOfUsers.Text = dgvAllUsers.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txValue_TextChanged(object sender, EventArgs e)
        {
            string FilterValue = "";

            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterValue = "PersonID";
                    break;
                case "User ID":
                    FilterValue = "UserID";
                    break;
                case "Full Name":
                    FilterValue = "FullName";
                    break;
                case "User Name":
                    FilterValue = "UserName";
                    break;
            }

            if (FilterValue == "None" || txValue.Text.Trim() == "")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lbNumbersOfUsers.Text = dgvAllUsers.RowCount.ToString();
                return;
            }

            if (FilterValue == "PersonID" || FilterValue == "UserID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterValue, txValue.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterValue, txValue.Text.Trim());


            lbNumbersOfUsers.Text = dgvAllUsers.RowCount.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0 || cbFilter.SelectedIndex == 5)
            {
                txValue.Visible = false;
            }
            else
            {
                txValue.Visible = true;
            }

            if (cbFilter.SelectedIndex == 5)
            {
                cbIsActive.Visible = true;
            }
            else
            {
                cbIsActive.Visible = false;
            }
        }

        private void txValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser addUpdateUser = new frmAddNewUser();

            addUpdateUser.ShowDialog();

            _RefreashList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            frmAddNewUser updateUser = new frmAddNewUser(UserID);

            updateUser.ShowDialog();

            _RefreashList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUser addUpdateUser = new frmAddNewUser();

            addUpdateUser.ShowDialog();

            _RefreashList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("are you sure want to delete this User ?"
                , "Warining", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsUser.Delete(UserID))
                {
                    MessageBox.Show("User deleted succefully", "Done");
                }
                else
                {
                    MessageBox.Show("User deleted Faild", "Done");
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
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            frmUserInfo UserInfo = new frmUserInfo(UserID);

            UserInfo.ShowDialog();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "IsActive";

            string FilterValue = cbIsActive.Text; 

            switch (FilterValue)
            {
                case "Active":
                    FilterValue = "1";
                    break;
                case "In Active":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
            {
                _dtUsers.DefaultView.RowFilter = "";
            }
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColoumn, FilterValue);

            lbNumbersOfUsers.Text = dgvAllUsers.RowCount.ToString();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            frmChangePassword changePassword = new frmChangePassword(UserID);

            changePassword.ShowDialog();

            _RefreashList();
        }
    }
}
