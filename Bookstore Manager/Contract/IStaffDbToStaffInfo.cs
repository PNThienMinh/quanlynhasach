using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffDbToStaffInfo
    {
        void OnGetAllUsersFromDatabaseSuccess(List<User> users);

        void OnGetAllUsersFromDatabaseFailure(string error);

        void OnDeleteUserFromDatabaseSuccessful();

        void OnDeleteUserFromDatabaseFailure(string error);

        void OnGetAllFunctionSuccessful(List<Function> functions);

        void OnGetAllFunctionsFail(string error);

        void OnUpdateInfoSuccessful(string msg);

        void OnUpdateInfoFail(string error);

        void OnUserNotExists();

        void OnUserIsExists();

        void OnInsertNewStaffSuccessful();

        void OnInsertNewStaffFail(string error);
    }
}
