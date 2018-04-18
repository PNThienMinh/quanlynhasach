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
        private IStaffDetail _staffDetail = null;
        private INewStaff _newStaff = null;

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

        public StaffInfo(INewStaff view)
        {
            _newStaff = view;
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

        public void UpdateUserInfo(User user)
        {
            _staffDb.UpdateUserInfo(user);
        }

        public void ValidateUser(string username)
        {
            _staffDb.CheckIfUserExists(username);
        }

        public void CreateNewStaff(User user)
        {
            _staffDb.InsertNewStaff(user);
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
            if (_staffDetail != null)
                _staffDetail.LoadListFunctionToUI(functions);
            else
            {
                _newStaff.LoadListFunctionToUI(functions);
            }
        }

        public void OnGetAllFunctionsFail(string error)
        {
            if (_staffDetail != null)
                _staffDetail.HandleGetFunctionsFail(error);
            else
            {
                _newStaff.HandleGetFunctionsFail(error);
            }
        }

        public void OnUpdateInfoSuccessful(string msg)
        {
            _staffDetail.RefreshUIAfterUpdate();
        }

        public void OnUpdateInfoFail(string error)
        {
            _staffDetail.NotifyUpdateFail(error);
        }

        public void OnUserNotExists()
        {
            _newStaff.ValidateUserNotExists();
        }

        public void OnUserIsExists()
        {
            _newStaff.UserIsExists();
        }

        public void OnInsertNewStaffSuccessful()
        {
            _newStaff.CreateStaffSuccessful();
        }

        public void OnInsertNewStaffFail(string error)
        {
            _newStaff.FailToCreateStaff(error);
        }

        //----------------------



    }
}
