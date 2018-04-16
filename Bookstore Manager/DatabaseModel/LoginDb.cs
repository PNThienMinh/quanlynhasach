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
    public class LoginDb : ILoginDb
    {

        private SqlConnection _connection = null;
        private ILoginDbToLoginInfo _listener = null;

        public LoginDb(ILoginDbToLoginInfo listener)
        {
            _listener = listener;
        }

        public void GetUser(string username, string password)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmd = new SqlCommand("getUser", _connection) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new SqlParameter("@Username", username));
                    cmd.Parameters.Add(new SqlParameter("@Password", password));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            _listener.OnGetUserFromDatabaseFailure("Wrong username or password!");
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
                            user.Username = username;
                            user.Password = password;
                            user.IDFunc = (int) reader["MaCV"];
                            _listener.OnGetUserFromDatabaseSuccess(user);
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
                    _listener.OnGetUserFromDatabaseFailure(exception.Message);
                }
            }
        }

    }
}
