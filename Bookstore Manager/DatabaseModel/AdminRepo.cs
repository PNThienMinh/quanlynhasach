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
using Rule = DTO.Rule;

namespace Data
{
    public class AdminRepo : IAdminRepo
    {
        private IAdminRepoListener _listener;
        private SqlConnection _connection = null;

        public AdminRepo(IAdminRepoListener listener)
        {
            _listener = listener;
        }

        public void LoadData()
        {
            Rule rule = new Rule();
            StoreReport report = new StoreReport();
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetRule =
                        new SqlCommand("getRule", _connection) { CommandType = CommandType.StoredProcedure };

                    using (SqlDataReader reader = cmdGetRule.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                rule.MinImport = (int)reader["SoLuongNhapItNhat"];
                                rule.MaxIndebtedness = Convert.ToInt32(reader["SoTienNoToiDa"]);
                                rule.MaxInventory = (int)reader["SoLuongTonToiDaTruocNhap"];
                                rule.MinInventory = (int)reader["SoLuongTonSauToiThieu"];
                            }
                    }

                    SqlCommand cmdGetReport =
                        new SqlCommand("getRevenue", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdGetReport.Parameters.Add(new SqlParameter("@date", DateTime.Today));
                    using (SqlDataReader reader = cmdGetReport.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                report.Revenue = Convert.ToInt32(reader[reader.GetName(0)]);
                            }
                    }

                    cmdGetReport =
                        new SqlCommand("getSumsBooksInventories", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdGetReport.Parameters.Add(new SqlParameter("@date", DateTime.Today));
                    using (SqlDataReader reader = cmdGetReport.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                report.NumBookImport = (int)reader[reader.GetName(0)];
                            }
                    }

                    cmdGetReport =
                        new SqlCommand("getBooksQuantitiesSold", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdGetReport.Parameters.Add(new SqlParameter("@date", DateTime.Today));
                    using (SqlDataReader reader = cmdGetReport.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                report.NumBookSold = (int)reader[reader.GetName(0)];
                            }
                    }

                    cmdGetReport =
                        new SqlCommand("getQuantitiesBookInStock", _connection) { CommandType = CommandType.StoredProcedure };
                    using (SqlDataReader reader = cmdGetReport.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                report.NumBookInStock = (int)reader[reader.GetName(0)];
                            }
                    }

                    _listener.OnGetDataSuccess(rule, report);

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

        public void ChangeRule(Rule rule)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdate = new SqlCommand("changeRule", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdUpdate.Parameters.Add(new SqlParameter("@minImport", rule.MinImport));
                    cmdUpdate.Parameters.Add(new SqlParameter("@maxInventory", rule.MaxInventory));
                    cmdUpdate.Parameters.Add(new SqlParameter("@minInventory", rule.MinInventory));
                    cmdUpdate.Parameters.Add(new SqlParameter("@maxIndebtedness", rule.MaxIndebtedness));

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        _listener.OnChangeRuleSuccess();

                    }
                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                }
            }
        }
    }
}
