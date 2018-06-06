using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffRepo
    {
        void GetAllUsersFromDatabase();

        void FetchListFunctions();

        void UpdateUserInfo(User user);

        void CheckIfUserExists(string username);

        void InsertNewStaff(User user);
    }
}
