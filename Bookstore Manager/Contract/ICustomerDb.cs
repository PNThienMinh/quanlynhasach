using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ICustomerDb
    {
        void GetAllCustomersFromDb();

        void InsertNewCustomer(Customer customer);

        void DeleteCustomer(int id);

        void UpdateCustomerInfo(Customer customer);
    }
}
