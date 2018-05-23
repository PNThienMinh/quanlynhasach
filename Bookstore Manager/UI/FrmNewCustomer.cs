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
    public partial class FrmNewCustomer : DevExpress.XtraEditors.XtraForm, ICustomerDetail
    {
        private ICustomerInfo _customerInfo;
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
            Dictionary<int, string> dataSource = new Dictionary<int, string>();
            dataSource.Add(0, "Nam");
            dataSource.Add(1, "Nữ");
            dataSource.Add(2, "Khác");

            cbSex.DataSource = new BindingSource(dataSource, null);
            cbSex.DisplayMember = "Value";
            cbSex.ValueMember = "Key";
        }

        private void InitComponentForEditCustomer()
        {
            InitComboBox();
            FillData();
            _customerInfo = new CustomerInfo(this);
            btnEdit.Visible = true;
            btnCreate.Enabled = false;
            btnCreate.Text = "Cập nhật";
            tbName.Enabled = false;
            tbCity.Enabled = false;
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
            tbCity.Text = city;
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
            InitComboBox();_customerInfo = new CustomerInfo(this);
            cbSex.Text = "--Chọn--";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Equals("") || tbCity.Text.Trim().Equals("") || tbDistrict.Text.Trim().Equals("")
                || tbEmail.Text.Trim().Equals("") || tbPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường!", "Nhắc nhở", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }

            Customer customer = new Customer();
            if (_customer != null)
                customer.ID = _customer.ID;
            customer.Name = tbName.Text.Trim();
            customer.Address = tbDistrict.Text.Trim() + '-' + tbCity.Text.Trim();
            customer.Email = tbEmail.Text.Trim();
            customer.Sex = cbSex.Text; customer.PhoneNum = tbPhoneNo.Text.Trim();


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
            tbCity.Enabled = true;
            tbDistrict.Enabled = true;
            tbEmail.Enabled = true;
            tbPhoneNo.Enabled = true;
            cbSex.Enabled = true;
        }

        public void NotifyCustomerInfoNotValid(string msg)
        {
            MessageBox.Show("Trường: " + msg + " không hợp lệ", "Nhắc nhở", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void NotifyInsertCustomerSuccessful()
        {
            MessageBox.Show("Thêm khách hàng thành công!", "Hoàn tất", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public void ErrorOccurWhenCreateCustomer(string msg)
        {
            // TODO:
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


    }
}