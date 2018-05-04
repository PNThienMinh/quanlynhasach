using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Contract;
using DevExpress.XtraEditors;
using DTO;

namespace UI
{
    public partial class FrmNewStaff : DevExpress.XtraEditors.XtraForm, INewStaff
    {

        private IStaffToStaffInfo _business;

        public FrmNewStaff()
        {
            InitializeComponent();
            _business = new StaffInfo(this);
            _business.GetListFunctions();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Equals("") || tbPhoneNo.Text.Equals("") || cbSex.Text.Equals("") ||
                datePicker.Value == DateTime.Parse("1/1/1990")
                || tbPhoneNo.Text.Equals("") || cbFunc.Text.Equals("") || tbUsername.Text.Equals("") || tbPassword.Text.Equals("") ||
                tbConfirmPassword.Text.Equals(""))
            {
                MessageBox.Show("Please fill all fields required!", "Notification", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!tbPassword.Text.Equals(tbConfirmPassword.Text))
            {
                tbConfirmPassword.Text = "";
                tbConfirmPassword.Focus();
            }


            SubmitUserToDatabase();
        }

        private void SubmitUserToDatabase()
        {
            User user = new User();
            user.Name = tbName.Text;
            user.Sex = cbSex.Text;
            user.Email = tbEmail.Text;
            user.PhoneNum = tbPhoneNo.Text;
            user.BirthDate = datePicker.Value;
            user.IDFunc = ((Function)cbFunc.SelectedItem).ID;
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            user.MId = tbUID.Text;

            _business.CreateNewStaff(user);
        }

        public void LoadListFunctionToUI(List<Function> functions)
        {
            functionBindingSource.DataSource = functions;
        }

        public void HandleGetFunctionsFail(string error)
        {
            // TODO: ...
        }

        private void ValidateUser(string username)
        {
            _business.ValidateUser(username);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals(""))
                UserIsExists();
            else
                ValidateUser(tbUsername.Text);
        }

        public void ValidateUserNotExists()
        {
            btnCreate.Enabled = true;
            btnValidate.Hide();
        }

        public void UserIsExists()
        {
            tbUsername.Text = "";
            tbUsername.HintText = "Username is exists!";
            tbUsername.Focus();
        }

        public void CreateStaffSuccessful()
        {
            MessageBox.Show("Create successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void FailToCreateStaff(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}