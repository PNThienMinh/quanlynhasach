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
using Business;
using Contract;
using DTO;

namespace GUI
{
    public partial class FrmStaff : Form, IStaffContract
    {
        private IStaffToStaffInfo _business;

        private int rowSelected = -1;

        public FrmStaff()
        {
            InitializeComponent();
            IninializeBussiness();
            SetupControls();
        }

        private void IninializeBussiness()
        {
            _business = new StaffInfo(this);
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            _business.GetListUsersExists();
        }

        private void SetupControls()
        {
            // textboxSeach
            tbSearch.Text = "Search here";
            tbSearch.ForeColor = SystemColors.GrayText;
            tbSearch.Leave += new System.EventHandler(tbSearch_Leave);
            tbSearch.Enter += new System.EventHandler(tbSearch_Enter);

            //

        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search here")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length == 0)
            {
                tbSearch.Text = "Search here";
                tbSearch.ForeColor = SystemColors.GrayText;
            }
        }


        public void DisplayListUsersToUI(List<User> users)
        {
            userBindingSource.DataSource = users;

        }

        public void OnFetchDataFailure(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void NotifyDeleteSuccessful()
        {
            MessageBox.Show("Delete successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvListStaffs.Rows.RemoveAt(rowSelected);
        }

        public void ShowErrorDeleteFailure(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            FrmNewStaff newStaff = new FrmNewStaff();
            newStaff.ShowDialog(this);
        }

        private void dgvListStaffs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvListStaffs.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && hti.RowIndex < dgvListStaffs.RowCount)
                {
                    dgvListStaffs.ClearSelection();
                    dgvListStaffs.Rows[hti.RowIndex].Selected = true;
                    rowOption.Enabled = true;
                }
                else
                {
                    rowOption.Enabled = false;
                }
            }
        }

        private void itemDetail_Click(object sender, EventArgs e)
        {
            User user = null;
            foreach (DataGridViewRow row in dgvListStaffs.SelectedRows)
            {

                user = (User)row.DataBoundItem;
            }

            FrmStaffDetail frmStaffDetail = new FrmStaffDetail(user);
            frmStaffDetail.ShowDialog();
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this staff?",
                "Confirm Delete!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvListStaffs.SelectedRows)
                {
                    string username = row.Cells[0].Value.ToString();
                    rowSelected = row.Index;
                    _business.DeleteUser(username);
                }
            }
            else
            {
                // Do nothing!
            }
        }
    }
}
