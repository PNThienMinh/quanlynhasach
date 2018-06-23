using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IAdminService
    {
        void LoadData();

        void ChangeRule(Rule newRule);
    }
}
