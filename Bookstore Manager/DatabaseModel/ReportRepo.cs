using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using Contract;
using DTO;

namespace Data
{
    public class ReportRepo : IReportRepo
    {
        private IReportRepoListener _listener;
        private SqlConnection _connection;

        public ReportRepo(IReportRepoListener listener)
        {
            this._listener = listener;
        }

        public void GetInventoryReportOfDate(DateTime date)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetInvetoryReportThisMonth =
                        new SqlCommand("getInventoryReport", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdGetInvetoryReportThisMonth.Parameters.Add(new SqlParameter("@date", date));

                    List<InventoryReport> listReports = new List<InventoryReport>();

                    using (SqlDataReader reader = cmdGetInvetoryReportThisMonth.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                InventoryReport inventoryReport = new InventoryReport
                                {
                                    BookID = (int) reader["MaDinhDanh"],
                                    BookName = reader["TenSach"] as string,
                                    InEarly = (int) reader["TonDau"],
                                    OnArise = (int) reader["TonPhatSinh"],
                                    InLast = (int) reader["TonCuoi"]
                                };
                                listReports.Add(inventoryReport);
                            }
                        }
                    }

                    SqlCommand cmdInventoryReportLastest =
                        new SqlCommand("getInventoryReportLastest", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdInventoryReportLastest.Parameters.Add(new SqlParameter("@date", date));

                    using (SqlDataReader reader = cmdInventoryReportLastest.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                InventoryReport inventoryReport = new InventoryReport
                                {
                                    BookID = (int) reader["MaDinhDanh"],
                                    BookName = reader["TenSach"] as string,
                                    InEarly = (int) reader["TonDau"],
                                    OnArise = (int) reader["TonPhatSinh"],
                                    InLast = (int) reader["TonCuoi"]
                                };

                                if(listReports.Count(r => r.BookID == inventoryReport.BookID) == 0)
                                    listReports.Add(inventoryReport);
                            }
                        }
                    }

                    if (listReports.Count != 0)
                    {
                        _listener.OnGetInventoryReportSuccessful(listReports);
                    }
                    else
                    {
                        _listener.OnGetInventoryReportFailure("Chưa có báo cáo cho tháng này!");
                    }


                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnGetInventoryReportFailure(exception.Message);
                }
            }
        }

        public void GetIndebtednessReportOfDate(DateTime date)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetIndebtednessReportThisMonth =
                        new SqlCommand("getIndebtednessReport", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdGetIndebtednessReportThisMonth.Parameters.Add(new SqlParameter("@date", date));

                    List<IndebtednessReport> listReports = new List<IndebtednessReport>();

                    using (SqlDataReader reader = cmdGetIndebtednessReportThisMonth.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IndebtednessReport indebtednessReport = new IndebtednessReport()
                                {
                                    CustomerID = (int)reader["MaKH"],
                                    CustomerName = reader["HoTen"] as string,
                                    InEarly = Convert.ToInt32(reader["NoDau"]),
                                    OnArise = Convert.ToInt32(reader["NoPhatSinh"]),
                                    InLast = Convert.ToInt32(reader["NoCuoi"])
                                };
                                listReports.Add(indebtednessReport);
                            }
                        }
                    }

                    SqlCommand cmdIndebtednessReportLastest =
                        new SqlCommand("getIndebtednessReportLastest", _connection) { CommandType = CommandType.StoredProcedure };
                    cmdIndebtednessReportLastest.Parameters.Add(new SqlParameter("@date", date));

                    using (SqlDataReader reader = cmdIndebtednessReportLastest.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IndebtednessReport indebtednessReport = new IndebtednessReport()
                                {
                                    CustomerID = (int)reader["MaKH"],
                                    CustomerName = reader["HoTen"] as string,
                                    InEarly = Convert.ToInt32(reader["NoDau"]),
                                    OnArise = Convert.ToInt32(reader["NoPhatSinh"]),
                                    InLast = Convert.ToInt32(reader["NoCuoi"])
                                };

                                if (listReports.Count(r => r.CustomerID == indebtednessReport.CustomerID) == 0)
                                    listReports.Add(indebtednessReport);
                            }
                        }
                    }

                    if (listReports.Count != 0)
                    {
                        _listener.OnGetIndebtednessReportSuccessful(listReports);
                    }
                    else
                    {
                        _listener.OnGetIndebtednessReportFailure("Chưa có báo cáo cho tháng này!");
                    }


                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnGetIndebtednessReportFailure(exception.Message);
                }
            }
        }
    }
}
