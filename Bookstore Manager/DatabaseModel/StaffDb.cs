using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using DTO;

namespace DatabaseModel
{
    public class StaffDb : IStaffDb
    {

        private SqlConnection _connection = null;
        private IStaffDbToStaffInfo _listener;

        public StaffDb(IStaffDbToStaffInfo listener)
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
                                _listener.OnGetAllUsersFromDatabaseFailure("No user!");
                            while (reader.Read())
                            {
                                User user = new User();
                                user.Name = (string)reader["Hoten"];
                                user.Sex = (string)reader["GioiTinh"];
                                user.BirthDate = (DateTime)reader["Ngaysinh"];
                                user.MId = (string)reader["CMND"];
                                user.Email = (string)reader["Email"];
                                user.PhoneNum = (string)reader["SDT"];
                                user.Funtion = (string)reader["TenChucVu"];
                                user.Username = (string)reader["TenDangNhap"];
                                user.Password = (string)reader["MatKhau"];
                                user.IDFunc = (int)reader["MaCV"];
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

        public void DeleteStaffFromDataBase(string username)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdDeleteUser = new SqlCommand("deleteUser", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdDeleteUser.Parameters.Add(new SqlParameter("@username", username));

                    int rowsAffected = cmdDeleteUser.ExecuteNonQuery();
                    if (rowsAffected != 2)
                    {
                        _listener.OnDeleteUserFromDatabaseFailure("User not exist!");
                    }
                    else
                    {
                        _listener.OnDeleteUserFromDatabaseSuccessful();
                    }
                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnDeleteUserFromDatabaseFailure(e.Message);
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
                    SqlCommand cmdGetAllUser = new SqlCommand("getAllFunc", _connection) { CommandType = CommandType.StoredProcedure };

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
    }

}

