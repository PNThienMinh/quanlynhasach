using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using DatabaseModel;
using DTO;

namespace Business
{
    public class CustomerInfo : ICustomerInfo, ICustomerDbToCustomerInfo
    {

        private ICustomerView _customerView;
        private ICustomerDb _db;
        private ICustomerDetail _customerDetail;

        public CustomerInfo(ICustomerView view)
        {
            this._customerView = view;
            _db = new CustomerDb(this);
        }

        public CustomerInfo(ICustomerDetail customerDetail)
        {
            this._customerDetail = customerDetail;
            _db = new CustomerDb(this);
        }

        public void LoadAllCustomers()
        {
            _db.GetAllCustomersFromDb();
        }

        public void CreateNewCustomer(Customer customer)
        {
            string notValidField = "";
            if (!customer.Name.Contains(' ') || customer.Name.Length < 5)
                notValidField += "Họ và tên | ";
            if (!customer.Email.Contains('@') || !customer.Email.Contains('.'))
                notValidField += "Email | ";
            if (customer.PhoneNum.Length < 10 || customer.PhoneNum.Length > 11)
                notValidField += "Số điện thoại | ";
            if (customer.Address.Length < 6)
                notValidField += "Quận/Huyện | Tỉnh/Thành phố";

            if (notValidField.Length > 0)
               _customerDetail.NotifyCustomerInfoNotValid(notValidField);

            else
                _db.InsertNewCustomer(customer);
        }

        public void DeleteCustomerWithId(int id)
        {
            _db.DeleteCustomer(id);
        }

        public void EditCustomer(Customer customer)
        {
            string notValidField = "";
            if (!customer.Name.Contains(' ') || customer.Name.Length < 5)
                notValidField += "Họ và tên | ";
            if (!customer.Email.Contains('@') || !customer.Email.Contains('.'))
                notValidField += "Email | ";
            if (customer.PhoneNum.Length < 10 || customer.PhoneNum.Length > 11)
                notValidField += "Số điện thoại | ";
            if (customer.Address.Length < 6)
                notValidField += "Quận/Huyện | Tỉnh/Thành phố";

            if (notValidField.Length > 0)
                _customerDetail.NotifyCustomerInfoNotValid(notValidField);

            else
            {
                _db.UpdateCustomerInfo(customer);
            }
        }

        public void OnGetAllCustomersSuccessful(List<Customer> customers)
        {
            _customerView.DislayCustomers(customers);
        }

        public void OnGetAllCustomersFailure(string msg)
        {
            _customerView.ErrorOccurWhenLoadCustomers(msg);
        }

        public void OnInsertCustomerSuccessful()
        {
            _customerDetail.NotifyInsertCustomerSuccessful();
        }

        public void OnInsertCustomerFailure(string msg)
        {
            _customerDetail.ErrorOccurWhenCreateCustomer(msg);
        }

        public void OnDeleteCustomerSuccess()
        {
            _customerView.NotifyDeleteCustomerSuccessful();
        }

        public void OnUpdateCustomerSuccess()
        {
            _customerDetail.NotifyUpdateCustomerSuccessful();
        }
    }
}
