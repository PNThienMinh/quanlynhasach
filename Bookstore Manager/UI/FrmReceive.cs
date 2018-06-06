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
            if (tbReceive.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập số tiền thu!", "Nhắc nhở", MessageBoxButtons.OK);

            _business.ReceiveIndebtedness(_customer, Int32.Parse(tbReceive.Text.Trim()));
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

        public void NotifyReceiveIsNotValid()
        {
            throw new NotImplementedException();
        }
    }
}