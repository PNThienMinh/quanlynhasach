using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffService
    {
        void GetListUsersExists();

        void GetListFunctions();

        void UpdateUserInfo(User user);

        void ValidateUser(string username);

        void CreateNewStaff(User user);
    }
}
