using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffDb
    {
        void GetAllUsersFromDatabase();

        void DeleteStaffFromDataBase(string username);

        void FetchListFunctions();

        void UpdateUserInfo(User user);

        void CheckIfUserExists(string username);

        void InsertNewStaff(User user);
    }
}
