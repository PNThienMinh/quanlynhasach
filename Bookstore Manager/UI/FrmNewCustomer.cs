using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Contract;
using DTO;
using Services;

namespace UI
{
    public partial class FrmNewCustomer : DevExpress.XtraEditors.XtraForm, ICustomerDetailListener
    {
        private ICustomerService _customerInfo;
        private int flagMode;
        private Customer _customer;

        public FrmNewCustomer()
        {
            InitializeComponent();
            this.flagMode = 0;
            InitComponentsForNewCustomer();
        }

        public FrmNewCustomer(Customer customer)
        {
            InitializeComponent();
            this.flagMode = 1;
            this._customer = customer;
            InitComponentForEditCustomer();
        }

        private void InitComboBox()
        {
            Dictionary<int, string> dataSource = new Dictionary<int, string> { { 0, "Nam" }, { 1, "Nữ" }, { 2, "Khác" } };

            cbSex.DataSource = new BindingSource(dataSource, null);
            cbSex.DisplayMember = "Value";
            cbSex.ValueMember = "Key";
        }

        private void InitComponentForEditCustomer()
        {
            InitComboBox();
            FillData();
            _customerInfo = new CustomerService(this);
            btnEdit.Visible = true;
            btnCreate.Enabled = false;
            btnCreate.Text = "Cập nhật";
            tbName.Enabled = false;
            cbProvince.Enabled = false;
            tbDistrict.Enabled = false;
            tbEmail.Enabled = false;
            tbPhoneNo.Enabled = false;
            cbSex.Enabled = false;
        }

        private void FillData()
        {
            char[] charSplit = { '-' };
            string district = _customer.Address.Split(charSplit)[0];
            string city = _customer.Address.Split(charSplit)[1];

            tbName.Text = _customer.Name;
            cbProvince.Text = city;
            tbDistrict.Text = district;
            tbPhoneNo.Text = _customer.PhoneNum;
            tbEmail.Text = _customer.Email;
            switch (_customer.Sex)
            {
                case "Nam":
                    cbSex.SelectedIndex = 0;
                    break;
                case "Nữ":
                    cbSex.SelectedIndex = 1;
                    break;
                default:
                    cbSex.SelectedIndex = 2;
                    break;

            }
        }

        private void InitComponentsForNewCustomer()
        {
            InitComboBox();
            _customerInfo = new CustomerService(this);
            cbSex.Text = "--Chọn--";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Equals("") || cbProvince.Text.Trim().Equals("") || tbDistrict.Text.Trim().Equals("")
                || tbEmail.Text.Trim().Equals("") || tbPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường!", "Nhắc nhở", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }

            if (lbEmailError.Visible || lbNameError.Visible || lbPhoneError.Visible)
                return;

            Customer customer = new Customer();
            if (_customer != null)
                customer.ID = _customer.ID;
            customer.Name = tbName.Text.Trim();
            customer.Address = tbDistrict.Text.Trim() + '-' + cbProvince.Text.Trim();
            customer.Email = tbEmail.Text.Trim();
            customer.Sex = cbSex.Text;
            customer.PhoneNum = tbPhoneNo.Text.Trim();


            if (flagMode == 0)
                _customerInfo.CreateNewCustomer(customer);
            else
            {
                _customerInfo.EditCustomer(customer);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            tbName.Enabled = true;
            cbProvince.Enabled = true;
            tbDistrict.Enabled = true;
            tbEmail.Enabled = true;
            tbPhoneNo.Enabled = true;
            cbSex.Enabled = true;
        }

        public void NotifyInsertCustomerSuccessful()
        {
            MessageBox.Show("Thêm khách hàng thành công!", "Hoàn tất", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public void ErrorOccurWhenCreateCustomer(string msg)
        {
            MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK);
        }

        public void NotifyUpdateCustomerSuccessful()
        {
            MessageBox.Show("Cập nhật khách hàng thành công!", "Hoàn tất", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).Text =
                Ultilities.ToTitleCase(((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).Text);
            if (!Ultilities.IsValidName(tbName.Text.Trim()))
            {
                lbNameError.Text = "Tên không hợp lệ!";
                lbNameError.Visible = true;
                tbName.Focus();
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (!Ultilities.IsValidEmail(tbEmail.Text.Trim()))
            {
                lbEmailError.Text = "Email không hợp lệ!";
                lbEmailError.Visible = true;
                tbEmail.Focus();
            }
        }

        private void tbEmail_OnValueChanged(object sender, EventArgs e)
        {
            if (lbEmailError.Visible == true)
                lbEmailError.Visible = false;
        }

        private void tbName_OnValueChanged(object sender, EventArgs e)
        {
            if (lbNameError.Visible == true)
                lbNameError.Visible = false;
        }

        private void tbPhoneNo_OnValueChanged(object sender, EventArgs e)
        {
            if (lbPhoneError.Visible == true)
                lbPhoneError.Visible = false;
        }

        private void tbPhoneNo_Leave(object sender, EventArgs e)
        {
            if (!Ultilities.IsValidPhoneNumber(tbPhoneNo.Text.Trim()))
            {
                lbPhoneError.Text = "Số điện thoại không hợp lệ!";
                lbPhoneError.Visible = true;
                tbPhoneNo.Focus();
            }
        }

        private void tbDistrict_OnValueChanged(object sender, EventArgs e)
        {
            if (lbDisError.Visible)
                lbDisError.Visible = false;
        }

        private void tbDistrict_Leave(object sender, EventArgs e)
        {
            if (!Ultilities.IsValidDistrict(tbDistrict.Text.Trim()))
            {
                lbDisError.Visible = true;
                tbDistrict.Focus();
            }
        }
    }
}