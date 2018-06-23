using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IAdminRepoListener
    {
        void OnGetDataSuccess(Rule rule, StoreReport report);

        void OnChangeRuleSuccess();
    }
}
