using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ICustomerService
    {
        void LoadAllCustomers();

        void CreateNewCustomer(Customer customer);

        void EditCustomer(Customer customer);

        void ReceiveIndebtedness(Customer customer, int receivedMoney);

    }
}
