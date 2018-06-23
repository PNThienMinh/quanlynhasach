using System.Collections.Generic;
using System.Linq;
using Contract;
using Data;
using DTO;

namespace Services
{
    public class CustomerService : ICustomerService, ICustomerRepoListener
    {

        private ICustomerView _customerView;
        private ICustomerRepo _db;
        private ICustomerDetailListener _customerDetail;
        private IStallView _stallView;
        private IReceiveView _receiveView;


        public CustomerService(ICustomerView view)
        {
            this._customerView = view;
            _db = new CustomerRepo(this);
        }

        public CustomerService(ICustomerDetailListener customerDetail)
        {
            this._customerDetail = customerDetail;
            _db = new CustomerRepo(this);
        }

        public CustomerService(IReceiveView receiveView)
        {
            this._receiveView = receiveView;
            _db = new CustomerRepo(this);
        }

        public void LoadAllCustomers()
        {
            _db.GetAllCustomersFromDb();
        }

        public void CreateNewCustomer(Customer customer)
        {
            string notValidField = "";
            
            if (customer.Address.Length < 6)
                notValidField += "Quận/Huyện | Tỉnh/Thành phố";

            if (notValidField.Length > 0)
                _customerDetail.NotifyCustomerInfoNotValid(notValidField);

            else
                _db.InsertNewCustomer(customer);
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

        public void ReceiveIndebtedness(Customer customer, int receivedMoney)
        {
              _db.ReceiveIndebtedness(customer, receivedMoney);
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

        public void OnUpdateCustomerSuccess()
        {
            _customerDetail.NotifyUpdateCustomerSuccessful();
        }

        public void OnReceiveIndebtednessSuccessful()
        {
            _receiveView.NotifyReceiveSuccess();
        }

        public void OnReceiveIndebtednessFailure(string msg)
        {
            throw new System.NotImplementedException();
        }
    }
}
