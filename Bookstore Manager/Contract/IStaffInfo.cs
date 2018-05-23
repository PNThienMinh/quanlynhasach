using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffInfo
    {
        void GetListUsersExists();

        void DeleteUser(string username);

        void GetListFunctions();

        void UpdateUserInfo(User user);

        void ValidateUser(string username);

        void CreateNewStaff(User user);
    }
}
