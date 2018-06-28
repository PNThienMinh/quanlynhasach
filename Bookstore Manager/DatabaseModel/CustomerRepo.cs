using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Contract;
using DTO;

namespace Data
{
    public class CustomerRepo : ICustomerRepo
    {
        private SqlConnection _connection = null;
        private ICustomerRepoListener _listener;

        public CustomerRepo(ICustomerRepoListener listener)
        {
            this._listener = listener;
        }

        public void GetAllCustomersFromDb()
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetAllCustomers =
                        new SqlCommand("getAllCustomers", _connection) { CommandType = CommandType.StoredProcedure };

                    List<Customer> customers = new List<Customer>();

                    using (SqlDataReader reader = cmdGetAllCustomers.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            _listener.OnGetAllCustomersSuccessful(null);
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                ID = (int)reader["MaKH"],
                                Name = (string)reader["Hoten"],
                                Sex = (string)reader["GioiTinh"],
                                Address = (string)reader["DiaChi"],
                                Email = (string)reader["Email"],
                                PhoneNum = (string)reader["SDT"]

                            };
                            if (!(reader["SoTienNo"] is DBNull))
                                customer.Indebtedness = (int)reader["SoTienNo"];
                            customers.Add(customer);
                        }

                        _listener.OnGetAllCustomersSuccessful(customers);
                    }

                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnGetAllCustomersFailure(exception.Message);
                }
            }
        }

        public void InsertNewCustomer(Customer customer)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();

                    SqlCommand cmdGetCustomer = new SqlCommand("getCustomer", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdGetCustomer.Parameters.Add(new SqlParameter("@name", customer.Name));
                    using (SqlDataReader reader = cmdGetCustomer.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            SqlCommand cmdInsertNewCustomer = new SqlCommand("addNewCustomer", _connection)
                            { CommandType = CommandType.StoredProcedure };

                            cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@name", customer.Name));
                            cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@sex", customer.Sex));
                            cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@addr", customer.Address));
                            cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@email", customer.Email));
                            cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@phoneno", customer.PhoneNum));


                            int rowsAffected = cmdInsertNewCustomer.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                _listener.OnInsertCustomerSuccessful();
                            }
                            else
                            {
                                _listener.OnInsertCustomerFailure("Thêm khách hàng thất bại");
                            }
                        }
                        else
                        {
                            Customer c = new Customer();
                            while (reader.Read())
                            {
                                c.Name = (string)reader["Hoten"];
                                c.Email = (string)reader["Email"];
                                c.PhoneNum = (string)reader["SDT"];
                            }

                            if (CheckIfCustomerDuplicate(c, customer))
                            {
                                _listener.OnInsertCustomerFailure("Khách hàng đã tồn tại!");
                            }
                            else
                            {
                                SqlCommand cmdInsertNewCustomer = new SqlCommand("addNewCustomer", _connection)
                                { CommandType = CommandType.StoredProcedure };

                                cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@name", customer.Name));
                                cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@sex", customer.Sex));
                                cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@addr", customer.Address));
                                cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@email", customer.Email));
                                cmdInsertNewCustomer.Parameters.Add(new SqlParameter("@phoneno", customer.PhoneNum));


                                int rowsAffected = cmdInsertNewCustomer.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    _listener.OnInsertCustomerSuccessful();
                                }
                                else
                                {
                                    _listener.OnInsertCustomerFailure("Thêm khách hàng thất bại");
                                }
                            }

                        }
                    }
                }

                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnInsertCustomerFailure(e.Message);
                }
            }
        }

        public void UpdateCustomerInfo(Customer customer)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdateCustomer = new SqlCommand("updateCustomer", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdUpdateCustomer.Parameters.Add(new SqlParameter("@cusId", customer.ID));
                    cmdUpdateCustomer.Parameters.Add(new SqlParameter("@name", customer.Name));
                    cmdUpdateCustomer.Parameters.Add(new SqlParameter("@sex", customer.Sex));
                    cmdUpdateCustomer.Parameters.Add(new SqlParameter("@addr", customer.Address));
                    cmdUpdateCustomer.Parameters.Add(new SqlParameter("@email", customer.Email));
                    cmdUpdateCustomer.Parameters.Add(new SqlParameter("@phoneno", customer.PhoneNum));

                    int rowsAffected = cmdUpdateCustomer.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        _listener.OnUpdateCustomerSuccess();
                    }

                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnReceiveIndebtednessFailure(e.Message);
                }

            }
        }

        public void ReceiveIndebtedness(Customer customer, int indebtedness)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmd = new SqlCommand("receiveIndebtedness", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add(new SqlParameter("@dateCreate", DateTime.Today));
                    cmd.Parameters.Add(new SqlParameter("@customerId", customer.ID));
                    cmd.Parameters.Add(new SqlParameter("@receive", indebtedness));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        _listener.OnReceiveIndebtednessSuccessful();
                    }

                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnReceiveIndebtednessFailure(e.Message);
                }

            }
        }

        private static bool CheckIfCustomerDuplicate(Customer c1, Customer c2)
        {
            if (!c1.Name.Equals(c2.Name))
                return false;
            else
            {
                if (c1.Email.Equals(c2.Email) || c1.PhoneNum.Equals(c2.PhoneNum))
                    return true;
            }

            return false;
        }
    }
}

