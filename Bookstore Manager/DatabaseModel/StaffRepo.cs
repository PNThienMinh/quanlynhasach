using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Contract;
using DTO;

namespace Data
{
    public class StaffRepo : IStaffRepo
    {

        private SqlConnection _connection = null;
        private IStaffRepoListener _listener;

        public StaffRepo(IStaffRepoListener listener)
        {
            _listener = listener;
        }

        public void GetAllUsersFromDatabase()
        {
            {
                using (_connection = new SqlConnection(Config.ConnectionString))
                {
                    try
                    {
                        _connection.Open();
                        SqlCommand cmdGetAllUser =
                            new SqlCommand("getAllUsers", _connection) { CommandType = CommandType.StoredProcedure };

                        List<User> users = new List<User>();

                        using (SqlDataReader reader = cmdGetAllUser.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                _listener.OnGetAllUsersFromDatabaseFailure("No user!");
                                return;
                            }

                            while (reader.Read())
                            {
                                User user = new User();
                                user.Name = (string)reader["Hoten"];
                                user.Sex = (string)reader["GioiTinh"];
                                user.BirthDate = ((DateTime)reader["Ngaysinh"]);
                                user.MId = (string)reader["CMND"];
                                user.Email = (string)reader["Email"];
                                user.PhoneNum = (string)reader["SDT"];
                                user.Funtion = (string)reader["TenChucVu"];
                                user.Username = (string)reader["TenDangNhap"];
                                user.Password = (string)reader["MatKhau"];
                                user.IDFunc = (int)reader["MaCV"];
                                user.ID = (int)reader["MaNV"];
                                users.Add(user);
                            }

                            _listener.OnGetAllUsersFromDatabaseSuccess(users);
                        }

                    }
                    catch (Exception exception)
                    {
                        Trace.AutoFlush = true;
                        Trace.TraceInformation("Error Occur");
                        Trace.TraceError(exception.Message);
                        Trace.TraceWarning("Careful!");
                        Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                        _listener.OnGetAllUsersFromDatabaseFailure(exception.Message);
                    }
                }
            }
        }

        public void FetchListFunctions()
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetAllUser =
                        new SqlCommand("getAllFunc", _connection) { CommandType = CommandType.StoredProcedure };

                    List<Function> functions = new List<Function>();

                    using (SqlDataReader reader = cmdGetAllUser.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            _listener.OnGetAllFunctionsFail("No function found!");
                            return;
                        }

                        while (reader.Read())
                        {
                            Function function = new Function();
                            function.ID = (int)reader["MaCV"];
                            function.Func = (string)reader["TenChucVu"];
                            functions.Add(function);
                        }

                        _listener.OnGetAllFunctionSuccessful(functions);
                    }

                }
                catch (Exception exception)
                {
                    _listener.OnGetAllFunctionsFail(exception.Message);
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                }
            }
        }

        public void UpdateUserInfo(User user)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdate = new SqlCommand("updateUser", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdUpdate.Parameters.Add(new SqlParameter("@userID", user.ID));
                    cmdUpdate.Parameters.Add(new SqlParameter("@name", user.Name));
                    cmdUpdate.Parameters.Add(new SqlParameter("@sex", user.Sex));
                    cmdUpdate.Parameters.Add(new SqlParameter("@birth", user.BirthDate));
                    cmdUpdate.Parameters.Add(new SqlParameter("@email", user.Email));
                    cmdUpdate.Parameters.Add(new SqlParameter("@UID", user.MId));
                    cmdUpdate.Parameters.Add(new SqlParameter("@phone", user.PhoneNum));
                    cmdUpdate.Parameters.Add(new SqlParameter("@funcId", user.IDFunc));
                    cmdUpdate.Parameters.Add(new SqlParameter("@username", user.Username));
                    cmdUpdate.Parameters.Add(new SqlParameter("@password", user.Password));

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    if (rowsAffected < 1 || rowsAffected > 2)
                    {
                        _listener.OnUpdateInfoFail("Fail to update!");
                    }
                    else
                    {
                        _listener.OnUpdateInfoSuccessful("Success!");
                    }
                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnUpdateInfoFail(e.Message);
                }
            }
        }

        public void CheckIfUserExists(string username)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdValidateUser =
                        new SqlCommand("validateAccount", _connection) { CommandType = CommandType.StoredProcedure };

                    cmdValidateUser.Parameters.Add(new SqlParameter("@Username", username));

                    using (SqlDataReader reader = cmdValidateUser.ExecuteReader())
                    {
                        if (reader.HasRows)
                            _listener.OnUserIsExists();
                        else
                        {
                            _listener.OnUserNotExists();
                        }
                    }

                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                }
            }
        }

        public void InsertNewStaff(User user)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdate = new SqlCommand("createStaff", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdUpdate.Parameters.Add(new SqlParameter("@Name", user.Name));
                    cmdUpdate.Parameters.Add(new SqlParameter("@Sex", user.Sex));
                    cmdUpdate.Parameters.Add(new SqlParameter("@Birth", user.BirthDate));
                    cmdUpdate.Parameters.Add(new SqlParameter("@Email", user.Email));
                    cmdUpdate.Parameters.Add(new SqlParameter("@NID", user.MId));
                    cmdUpdate.Parameters.Add(new SqlParameter("@PhoneNum", user.PhoneNum));
                    cmdUpdate.Parameters.Add(new SqlParameter("@IDFunc", user.IDFunc));
                    cmdUpdate.Parameters.Add(new SqlParameter("@Username", user.Username));
                    cmdUpdate.Parameters.Add(new SqlParameter("@Password", user.Password));

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    if (rowsAffected < 1 || rowsAffected > 2)
                    {
                        _listener.OnInsertNewStaffFail("Fail to create!");
                    }
                    else
                    {
                        _listener.OnInsertNewStaffSuccessful();
                    }
                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnInsertNewStaffFail(e.Message);
                }

            }
        }

    }
}

