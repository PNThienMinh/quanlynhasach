using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using DevExpress.XtraEditors;
using DTO;
using Services;

namespace UI
{
    public partial class FrmStaffDetail : DevExpress.XtraEditors.XtraForm, IStaffDetailView
    {
        private IStaffService _business;
        private User _user;

        public FrmStaffDetail()
        {
            InitializeComponent();
        }

        public FrmStaffDetail(User user)
        {
            InitializeComponent();
            this._user = user;
            DisplayStaffInfo(user);
            InitBusiness();
        }

        public void InitBusiness()
        {
            _business = new StaffService(this);
            _business.GetListFunctions();
        }

        private void DisplayStaffInfo(User user)
        {
            tbName.Text = user.Name;
            tbEmail.Text = user.Email;
            cbFunc.Text = user.Funtion;
            tbPhone.Text = user.PhoneNum;
            tbUID.Text = user.MId;
            tbSex.Text = user.Sex;
            datePicker.Value = user.BirthDate;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.FormatCustom = "dd/MM/yyyy";
        }

        public void LoadListFunctionToUI(List<Function> functions)
        {
            functionBindingSource.DataSource = functions;
            cbFunc.Text = _user.Funtion;
        }

        public void HandleGetFunctionsFail(string error)
        {
            throw new NotImplementedException();
        }

        public void RefreshUIAfterUpdate()
        {
            MessageBox.Show("Cập nhật thành công", "Hoàn tất", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void NotifyStaffInfoNotValid(string notValidFields)
        {
            MessageBox.Show("Trường " + notValidFields + "không hợp lê!", "Nhắc nhở", MessageBoxButtons.OK);
        }

        public void NotifyUpdateFail(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = _user.Username.Trim();
            user.Name = tbName.Text.Trim();
            user.Sex = tbSex.Text.Trim();
            user.BirthDate = datePicker.Value;
            user.Email = tbEmail.Text.Trim();
            user.IDFunc = ((Function)cbFunc.SelectedItem).ID;
            user.MId = tbUID.Text.Trim();
            user.PhoneNum = tbPhone.Text.Trim();
            user.ID = this._user.ID;

            if (!tbNewPassword.Text.Equals(tbConfirmPassword.Text))
            {
                tbConfirmPassword.ResetText();
                tbConfirmPassword.Focus();

            }
            user.Password = tbNewPassword.Text;

            _business.UpdateUserInfo(user);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbName.Enabled = true;
            tbConfirmPassword.Enabled = true;
            tbEmail.Enabled = true;
            tbNewPassword.Enabled = true;
            tbPhone.Enabled = true;
            tbSex.Enabled = true;
            tbUID.Enabled = true;
            cbFunc.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}