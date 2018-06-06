using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ICustomerRepo
    {
        void GetAllCustomersFromDb();

        void InsertNewCustomer(Customer customer);

        void UpdateCustomerInfo(Customer customer);

    }
}
