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
        private IStaffInfo _business;

        public FrmNewStaff()
        {
            InitializeComponent();
            _business = new StaffInfo(this);
            _business.GetListFunctions();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.FormatCustom = "dd/MM/yyyy";
        }

        public void LoadListFunctionToUI(List<Function> functions)
        {
            functionBindingSource.DataSource = functions;
        }

        public void HandleGetFunctionsFail(string error)
        {
            throw new NotImplementedException();
        }

        public void ValidateUserNotExists()
        {
            btnCreate.Enabled = true;
            btnValidate.Hide();
        }

        public void UserIsExists()
        {
            tbUsername.Text = "";
            tbUsername.HintText = "Tên tài khoản đã tồn tại!";
            tbUsername.Focus();
        }

        public void CreateStaffSuccessful()
        {
            MessageBox.Show("Thêm nhân viên thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void FailToCreateStaff(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void NotifyStaffInfoNotValid(string notValidField)
        {
            MessageBox.Show("Trường " + notValidField + "không hợp lê!", "Nhắc nhở", MessageBoxButtons.OK);
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
            user.Name = tbName.Text.Trim();
            user.Sex = cbSex.Text.Trim();
            user.Email = tbEmail.Text.Trim();
            user.PhoneNum = tbPhoneNo.Text.Trim();
            user.BirthDate = datePicker.Value;
            user.IDFunc = ((Function)cbFunc.SelectedItem).ID;
            user.Username = tbUsername.Text.Trim();
            user.Password = tbPassword.Text.Trim();
            user.MId = tbUID.Text.Trim();

            _business.CreateNewStaff(user);
        }

        private void ValidateUser(string username)
        {
            _business.ValidateUser(username);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals(""))
                UserIsExists();
            else
                ValidateUser(tbUsername.Text);
        }
    }
}