using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ICustomerRepoListener
    {
        void OnGetAllCustomersSuccessful(List<Customer> customers);

        void OnGetAllCustomersFailure(string msg);

        void OnInsertCustomerSuccessful();

        void OnInsertCustomerFailure(string msg);

        void OnUpdateCustomerSuccess();

    }
}
