using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IStaffDb
    {
        void GetAllUsersFromDatabase();

        void DeleteStaffFromDataBase(string username);

        void FetchListFunctions();
    }
}
