using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using DatabaseModel;
using DTO;

namespace Business
{
    public class StaffInfo : IStaffToStaffInfo, IStaffDbToStaffInfo
    {

        private IStaffContract _staffView;
        private IStaffDb _staffDb;
        private IStaffDetail _staffDetail;

        public StaffInfo(IStaffContract view)
        {
            _staffView = view;
            _staffDb = new StaffDb(this);
        }

        public StaffInfo(IStaffDetail view)
        {
            _staffDetail = view;
            _staffDb = new StaffDb(this);
        }
        

        // ---------------
        public void GetListUsersExists()
        {
            _staffDb.GetAllUsersFromDatabase();
        }

        public void DeleteUser(string username)
        {
            _staffDb.DeleteStaffFromDataBase(username);
        }

        public void GetListFunctions()
        {
            _staffDb.FetchListFunctions();
        }

        public void OnGetAllUsersFromDatabaseSuccess(List<User> users)
        {
            _staffView.DisplayListUsersToUI(users);
        }

        public void OnGetAllUsersFromDatabaseFailure(string error)
        {
            _staffView.OnFetchDataFailure(error);
        }

        public void OnDeleteUserFromDatabaseSuccessful()
        {
            _staffView.NotifyDeleteSuccessful();
        }

        public void OnDeleteUserFromDatabaseFailure(string error)
        {
           _staffView.ShowErrorDeleteFailure(error);
        }

        public void OnGetAllFunctionSuccessful(List<Function> functions)
        {
            _staffDetail.LoadListFunctionToUI(functions);
        }

        public void OnGetAllFunctionsFail(string error)
        {
            _staffDetail.HandleGetFunctionsFail(error);
        }

        //----------------------

        

    }
}
