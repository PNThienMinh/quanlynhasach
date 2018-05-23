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
    public class StaffInfo : IStaffInfo, IStaffDbToStaffInfo
    {

        private IStaffView _staffView;
        private IStaffDb _staffDb;
        private IStaffDetail _staffDetail = null;
        private INewStaff _newStaff = null;

        public StaffInfo(IStaffView view)
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
            string notValidField = "";
            if (!user.Name.Contains(' ') || user.Name.Length < 5)
                notValidField += "Họ và tên | ";
            if (!user.Email.Contains('@') || !user.Email.Contains('.'))
                notValidField += "Email | ";
            if (user.PhoneNum.Length < 10 || user.PhoneNum.Length > 11)
                notValidField += "Số điện thoại | ";
            
            if (notValidField.Length > 0)
                _staffDetail.NotifyStaffInfoNotValid(notValidField);

            else
                _staffDb.UpdateUserInfo(user);
        }

        public void ValidateUser(string username)
        {
            _staffDb.CheckIfUserExists(username);
        }

        public void CreateNewStaff(User user)
        {
            string notValidField = "";
            if (!user.Name.Contains(' ') || user.Name.Length < 5)
                notValidField += "Họ và tên | ";
            if (!user.Email.Contains('@') || !user.Email.Contains('.'))
                notValidField += "Email | ";
            if (user.PhoneNum.Length < 10 || user.PhoneNum.Length > 11)
                notValidField += "Số điện thoại | ";

            if (notValidField.Length > 0)
                _newStaff.NotifyStaffInfoNotValid(notValidField);

            else
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
