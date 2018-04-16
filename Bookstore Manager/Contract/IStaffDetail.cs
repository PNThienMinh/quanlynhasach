using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffDetail
    {
        void LoadListFunctionToUI(List<Function> functions);

        void HandleGetFunctionsFail(string error);
    }
}
