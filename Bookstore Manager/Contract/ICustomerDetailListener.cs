using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface ICustomerDetailListener
    {
        
        void NotifyInsertCustomerSuccessful();

        void ErrorOccurWhenCreateCustomer(string msg);

        void NotifyUpdateCustomerSuccessful();
    }
}
