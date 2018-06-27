using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using DevExpress.XtraEditors;
using DTO;
using Services;

namespace UI
{
    public partial class FrmReceive : DevExpress.XtraEditors.XtraForm, IReceiveView
    {
        private Customer _customer;
        private ICustomerService _business;

        public FrmReceive()
        {
            InitializeComponent();
        }

        public FrmReceive(Customer customer)
        {
            _customer = customer;
            _business = new CustomerService(this);
            InitializeComponent();
            DisplayInformation();
        }

        private void DisplayInformation()
        {
            tbName.Text = _customer.Name;
            tbAddr.Text = _customer.Address;
            tbEmail.Text = _customer.Email;
            tbDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            tbPhoneNo.Text = _customer.PhoneNum;
            tbIndebtedness.Text = _customer.Indebtedness.ToString();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (tbReceive.Text.Trim().Equals("") || Regex.Matches(tbReceive.Text.Trim(), @"[a-zA-Z]").Count > 0 ||
                !Ultilities.IsDigitsOnly(tbReceive.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số tiền thu hợp lê!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }

            int receive = Int32.Parse(tbReceive.Text.Trim());
            if (receive <= 0)
            {
                MessageBox.Show("Số tiền thu phải lớn hơn 0!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }
            if (receive > _customer.Indebtedness)
            {
                MessageBox.Show("Số tiền thu không được vượt quá số tiền khách hàng đang nợ!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }

            _business.ReceiveIndebtedness(_customer, receive);
        }

        private void tbReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void NotifyReceiveSuccess()
        {
            MessageBox.Show("Thu tiền thành công!", "Hoàn tất", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}