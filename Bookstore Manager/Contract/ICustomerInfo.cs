using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ICustomerInfo
    {
        void LoadAllCustomers();

        void CreateNewCustomer(Customer customer);

        void DeleteCustomerWithId(int id);

        void EditCustomer(Customer customer);
    }
}
