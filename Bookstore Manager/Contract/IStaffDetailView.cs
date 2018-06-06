using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffDetailView
    {
        void LoadListFunctionToUI(List<Function> functions);

        void HandleGetFunctionsFail(string error);

        void RefreshUIAfterUpdate();

        void NotifyStaffInfoNotValid(string notValidFields);

        void NotifyUpdateFail(string error);
    }
}
