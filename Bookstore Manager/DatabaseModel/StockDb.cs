using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class StockDb : IStockDb
    {
        private SqlConnection _connection;
        private IStockDbToStockInfo _listener;


        private BackgroundWorker sqlWorker;


        public StockDb(IStockDbToStockInfo listener)
        {
            this._listener = listener;
        }

        public void InsertBook(Book book)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdate = new SqlCommand("addBook", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdUpdate.Parameters.Add(new SqlParameter("@bookId", book.Identifier));
                    cmdUpdate.Parameters.Add(new SqlParameter("@bookName", book.Name));
                    cmdUpdate.Parameters.Add(new SqlParameter("@bookType", book.Category));
                    cmdUpdate.Parameters.Add(new SqlParameter("@datePublished", book.PublishedDate));
                    cmdUpdate.Parameters.Add(new SqlParameter("@price", book.Cost));
                    cmdUpdate.Parameters.Add(new SqlParameter("@authorName", book.Author));
                    cmdUpdate.Parameters.Add(new SqlParameter("@publisher", book.Publisher));
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        _listener.OnInsertBookToDbSuccessful();
                    else
                    {
                        _listener.OnInsertBookToDbFail("Can't insert this book!");
                    }

                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnInsertBookToDbFail(e.Message);
                }

            }
        }

        public void GetAllBookInDb()
        {
            sqlWorker = new BackgroundWorker();
            sqlWorker.DoWork += sqlWorker_DoWork;
            sqlWorker.RunWorkerCompleted += sqlWorker_Completed;
            sqlWorker.RunWorkerAsync();
        }

        public void GetStockContracts()
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetAllUser =
                        new SqlCommand("getStockContract", _connection) { CommandType = CommandType.StoredProcedure };

                    using (SqlDataReader reader = cmdGetAllUser.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            _listener.OnGetContractFailure("Cơ sở dữ liệu rỗng");
                        else
                        {
                            while (reader.Read())
                            {
                                int minImport = (int) reader["SoLuongNhapItNhat"];
                                int maxInventory = (int) reader["SoLuongTonToiDaTruocNhap"];
                                _listener.OnGetContractSuccess(minImport, maxInventory);
                            }
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
                    _listener.OnGetContractFailure(exception.Message);
                }
            }
        }

        public void UpdateStockContracts(int newMinImport, int newMaxInventory)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdate = new SqlCommand("changeStockContract", _connection)
                        { CommandType = CommandType.StoredProcedure };

                    cmdUpdate.Parameters.Add(new SqlParameter("@minImport", newMinImport));
                    cmdUpdate.Parameters.Add(new SqlParameter("@maxInventory", newMaxInventory));
                    
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        _listener.OnUpdateStockContractsSuccessful();
                    else
                    {
                        _listener.OnUpdateStockContractsFailure("Cập nhật cơ sở dữ liệu thất bại!");
                    }

                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnUpdateStockContractsFailure(e.Message);
                }

            }
        }

        private void sqlWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _listener.OnGetAllBookFail((string)e.Result);
            }
            else
                _listener.OnGetAllBookSuccess((List<Book>)e.Result);

        }

        private void sqlWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetAllUser =
                        new SqlCommand("getAllBooks", _connection) { CommandType = CommandType.StoredProcedure };

                    List<Book> books = new List<Book>();

                    using (SqlDataReader reader = cmdGetAllUser.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Book book = new Book();
                                book.Name = (string)reader["TenSach"];
                                book.Category = (string)reader["Theloai"];
                                book.PublishedDate = ((DateTime)reader["NgayXuatBan"]);
                                book.Cost = Convert.ToInt32(reader["DonGiaNhap"]);
                                book.Author = (string)reader["TenTG"];
                                book.Publisher = (string)reader["TenNXB"];
                                book.Identifier = (int)reader["MaDinhDanh"];
                                book.Inventory = (int)reader["SoLuongTon"];
                                books.Add(book);
                            }
                        }

                        e.Result = books;

                    }

                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    e.Result = exception.Message;
                    sqlWorker.CancelAsync();
                }

            }
        }
    }
}
