using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Contract;
using DTO;
using Excel = Microsoft.Office.Interop.Excel;


namespace Data
{
    public class StockRepo : IStockRepo
    {
        private SqlConnection _connection;
        private IStockDbToStockInfo _listener;

        private BackgroundWorker sqlWorker;

        private string receiptNotePath = Config.DataLocation +"PhieuNhap\\";

        private string _staffName;

        public StockRepo(IStockDbToStockInfo listener)
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
                    SqlCommand cmdInsertBook = new SqlCommand("addBook", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdInsertBook.Parameters.Add(new SqlParameter("@bookId", book.Identifier));
                    cmdInsertBook.Parameters.Add(new SqlParameter("@bookName", book.Name));
                    cmdInsertBook.Parameters.Add(new SqlParameter("@bookType", book.Category));
                    cmdInsertBook.Parameters.Add(new SqlParameter("@datePublished", book.PublishedDate));
                    cmdInsertBook.Parameters.Add(new SqlParameter("@price", book.Cost));
                    cmdInsertBook.Parameters.Add(new SqlParameter("@authorName", book.Author));
                    cmdInsertBook.Parameters.Add(new SqlParameter("@publisher", book.Publisher));
                    int rowsAffected = cmdInsertBook.ExecuteNonQuery();
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
            sqlWorker.DoWork += sqlWorker_DoWork_GetAllBooks;
            sqlWorker.RunWorkerCompleted += sqlWorker_Completed_GetAllBooks;
            sqlWorker.RunWorkerAsync();
        }

        public void GetStockContracts()
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetStockContract =
                        new SqlCommand("getStockContract", _connection) { CommandType = CommandType.StoredProcedure };

                    using (SqlDataReader reader = cmdGetStockContract.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            _listener.OnGetContractFailure("Cơ sở dữ liệu rỗng");
                        else
                        {
                            while (reader.Read())
                            {
                                int minImport = (int)reader["SoLuongNhapItNhat"];
                                int maxInventory = (int)reader["SoLuongTonToiDaTruocNhap"];
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
                    SqlCommand cmdChangeStockContract = new SqlCommand("changeStockContract", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdChangeStockContract.Parameters.Add(new SqlParameter("@minImport", newMinImport));
                    cmdChangeStockContract.Parameters.Add(new SqlParameter("@maxInventory", newMaxInventory));

                    int rowsAffected = cmdChangeStockContract.ExecuteNonQuery();
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

        public void InsertBooksReceipNote(string staffName, List<Book> books)
        {
            sqlWorker = new BackgroundWorker();
            sqlWorker.WorkerSupportsCancellation = true; sqlWorker.DoWork += sqlWorker_DoWork_AddNewBooksReceiptNote;
            sqlWorker.RunWorkerCompleted += sqlWorker_Completed_AddNewBooksReceiptNote;
            this._staffName = staffName;
            sqlWorker.RunWorkerAsync(books);
        }

        public void UpdateBookInfo(Book newBookInfo)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdUpdate = new SqlCommand("updateBookInfo", _connection)
                    { CommandType = CommandType.StoredProcedure };

                    cmdUpdate.Parameters.Add(new SqlParameter("@bookId", newBookInfo.ID));
                    cmdUpdate.Parameters.Add(new SqlParameter("@cost", newBookInfo.Cost));

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        _listener.OnUpdateBookInfoSuccessful();
                    else
                    {
                        _listener.OnUpdateBookInfoFailure("Cập nhật cơ sở dữ liệu thất bại!");
                    }

                }
                catch (Exception e)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(e.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    _listener.OnUpdateBookInfoFailure(e.Message);
                }

            }
        }

        private void sqlWorker_Completed_AddNewBooksReceiptNote(object sender, RunWorkerCompletedEventArgs e)
        {
            sqlWorker = null;
            if (e.Cancelled)
            {
                _listener.OnAddBookToReceiptNoteFail(e.Result.ToString());
            }
            else
                _listener.OnAddBookToReceiptNoteSuccessful(e.Result.ToString());
        }

        private void sqlWorker_DoWork_AddNewBooksReceiptNote(object sender, DoWorkEventArgs e)
        {
            List<Book> booksReceipt = (List<Book>)e.Argument;

            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdInsertBooksreceiptNote = new SqlCommand("createBooksReceiptNote", _connection)
                    { CommandType = CommandType.StoredProcedure };
                    SqlParameter returnParameter = cmdInsertBooksreceiptNote.Parameters.Add("receiptNoteId", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    cmdInsertBooksreceiptNote.Parameters.Add(new SqlParameter("@dateCreate", DateTime.Today));
                    cmdInsertBooksreceiptNote.Parameters.Add(new SqlParameter("@staffName", _staffName));

                    int rowsAffected = cmdInsertBooksreceiptNote.ExecuteNonQuery();
                    int receiptNoteId = (int)returnParameter.Value;

                    if (rowsAffected > 0)
                    {
                        Excel.Application xlApp = new
                            Microsoft.Office.Interop.Excel.Application();

                        Excel.Workbook xlWorkBook;
                        Excel.Worksheet xlWorkSheet;
                        object misValue = System.Reflection.Missing.Value;


                        xlWorkBook = xlApp.Workbooks.Add(misValue);
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                        xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[2, 8]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[2, 8]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                        xlWorkSheet.Cells[1, 1] = "PHIẾU NHẬP";
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[4, 3]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[4, 3]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[4, 1] = "Tên NV: " + _staffName;
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 6], xlWorkSheet.Cells[4, 8]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 6], xlWorkSheet.Cells[4, 8]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[4, 6] = "Ngày nhập: " + DateTime.Today.ToString("dd-MM-yyyy");

                        xlWorkSheet.Cells[6, 1] = "Mã sách";
                        xlWorkSheet.Cells[6, 2] = "Tên sách";
                        xlWorkSheet.Cells[6, 3] = "Thể loại";
                        xlWorkSheet.Cells[6, 4] = "Ngày xuất bản";
                        xlWorkSheet.Cells[6, 5] = "Giá nhập";
                        xlWorkSheet.Cells[6, 6] = "Tác giả";
                        xlWorkSheet.Cells[6, 7] = "Nhà xuất bản";
                        xlWorkSheet.Cells[6, 8] = "Số lượng nhập";
                        int rowIndex = 7;

                        foreach (Book book in booksReceipt)
                        {
                            SqlCommand cmdInsertStock = new SqlCommand("addBookIntoBooksReceiptNote", _connection)
                            {
                                CommandType = CommandType.StoredProcedure
                            };

                            cmdInsertStock.Parameters.Add(new SqlParameter("@bookId", book.ID));
                            cmdInsertStock.Parameters.Add(new SqlParameter("@count", book.Count));
                            cmdInsertStock.Parameters.Add(new SqlParameter("@dateCreate", DateTime.Today));

                            if (cmdInsertStock.ExecuteNonQuery() < 3)
                                sqlWorker.CancelAsync();
                            xlWorkSheet.Cells[rowIndex, 1] = book.Identifier;
                            xlWorkSheet.Cells[rowIndex, 2] = book.Name;
                            xlWorkSheet.Cells[rowIndex, 3] = book.Category;
                            xlWorkSheet.Cells[rowIndex, 4] = book.PublishedDate.ToString("dd-MM-yyyy");
                            xlWorkSheet.Cells[rowIndex, 5] = book.Cost.ToString();
                            xlWorkSheet.Cells[rowIndex, 6] = book.Author;
                            xlWorkSheet.Cells[rowIndex, 7] = book.Publisher;
                            xlWorkSheet.Cells[rowIndex, 8] = book.Count;
                            rowIndex++;
                        }

                        xlWorkSheet.Columns.AutoFit();

                        if (!Directory.Exists(receiptNotePath))
                        {
                            Directory.CreateDirectory(receiptNotePath);
                        }

                        xlWorkBook.SaveAs(receiptNotePath + "PN" + receiptNoteId + ".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        Marshal.ReleaseComObject(xlWorkSheet);
                        Marshal.ReleaseComObject(xlWorkBook);
                        Marshal.ReleaseComObject(xlApp);

                        e.Result = receiptNotePath + "PN" + receiptNoteId + ".xlsx";
                    }
                    else
                    {
                        sqlWorker.CancelAsync();
                    }

                }
                catch (Exception ex)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(ex.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    e.Result = ex.Message;
                    sqlWorker.CancelAsync();
                }

            }
        }

        private void sqlWorker_Completed_GetAllBooks(object sender, RunWorkerCompletedEventArgs e)
        {
            sqlWorker = null;
            if (e.Cancelled)
            {
                _listener.OnGetAllBookFail((string)e.Result);
            }
            else
                _listener.OnGetAllBookSuccess((List<Book>)e.Result);

        }

        private void sqlWorker_DoWork_GetAllBooks(object sender, DoWorkEventArgs e)
        {
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetAllBook =
                        new SqlCommand("getAllBooks", _connection) { CommandType = CommandType.StoredProcedure };

                    List<Book> books = new List<Book>();

                    using (SqlDataReader reader = cmdGetAllBook.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Book book = new Book();
                                book.ID = (int)reader["MaSach"];
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
