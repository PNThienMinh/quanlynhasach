using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ICustomerView
    {
        void DislayCustomers(List<Customer> customers);

        void ErrorOccurWhenLoadCustomers(string msg);

    }
}
