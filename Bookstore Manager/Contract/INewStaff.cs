using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface INewStaff
    {
        void LoadListFunctionToUI(List<Function> functions);

        void HandleGetFunctionsFail(string error);

        void ValidateUserNotExists();

        void UserIsExists();

        void CreateStaffSuccessful();

        void FailToCreateStaff(string error);

        void NotifyStaffInfoNotValid(string notValidField);
    }
}
