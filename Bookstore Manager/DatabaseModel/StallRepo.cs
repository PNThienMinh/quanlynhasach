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
    public class StallRepo : IStallRepo
    {
        private IStallRepoListener _listener;
        private SqlConnection _connection;

        private BackgroundWorker sqlWorker;

        private string billPath = Config.DataLocation+"HoaDon\\";

        private int _staffId;
        private int _customerId;
        private int _total;
        private int _due;

        public StallRepo(IStallRepoListener listener)
        {
            this._listener = listener;
        }

        public bool CheckIfUserCanBuy(Customer customer, int total, int due)
        {
            int maxDue = 0;
            int currentCustomerDue = customer.Indebtedness;

            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetMaxDue =
                        new SqlCommand("getMaxDue", _connection) { CommandType = CommandType.StoredProcedure };

                    using (SqlDataReader reader = cmdGetMaxDue.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            maxDue = Convert.ToInt32(reader["SoTienNoToiDa"]);
                        }
                    }

                    if (due + currentCustomerDue > maxDue)
                        return false;
                    return true;

                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    return false;
                }
            }
        }

        public bool CheckIfAllBooksMeetRequirement(List<Book> books)
        {
            int minInventory = 0;
            List<int> listBookError = new List<int>();
            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdGetMinInventory =
                        new SqlCommand("getMinInventory", _connection) { CommandType = CommandType.StoredProcedure };

                    using (SqlDataReader reader = cmdGetMinInventory.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            minInventory = (int)reader["SoLuongTonSauToiThieu"];
                        }
                    }

                    foreach (var book in books)
                    {
                        if (book.Inventory - book.Count < minInventory)
                            listBookError.Add(book.Identifier);
                    }
                    if (listBookError.Count < 1)
                        return true;

                    _listener.OnListBookNotMeetRequirement(listBookError);
                    return false;

                }
                catch (Exception exception)
                {
                    Trace.AutoFlush = true;
                    Trace.TraceInformation("Error Occur");
                    Trace.TraceError(exception.Message);
                    Trace.TraceWarning("Careful!");
                    Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
                    return false;
                }
            }
        }

        public void CreateBill(int staffId, int customerId, List<Book> booksInBill, int total, int due)
        {

            sqlWorker = new BackgroundWorker();
            sqlWorker.WorkerSupportsCancellation = true; sqlWorker.DoWork += sqlWorker_DoWork_CreateBill;
            sqlWorker.RunWorkerCompleted += sqlWorker_Completed_CreateBill;
            _staffId = staffId;
            _customerId = customerId;
            _total = total;
            _due = due;
            sqlWorker.RunWorkerAsync(booksInBill);

        }

        private void sqlWorker_Completed_CreateBill(object sender, RunWorkerCompletedEventArgs e)
        {
            sqlWorker = null;
            if (e.Cancelled)
            {
                _listener.OnCreateBillFailure(e.Result.ToString());
            }
            else
                _listener.OnCreateBillSuccessful(e.Result.ToString());
        }

        private void sqlWorker_DoWork_CreateBill(object sender, DoWorkEventArgs e)
        {
            List<Book> books = (List<Book>)e.Argument;

            using (_connection = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmdCreateBill = new SqlCommand("addNewBill", _connection)
                    { CommandType = CommandType.StoredProcedure };
                    SqlParameter returnParameter = cmdCreateBill.Parameters.Add("billId", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    cmdCreateBill.Parameters.Add(new SqlParameter("@dateCreate", DateTime.Today));
                    cmdCreateBill.Parameters.Add(new SqlParameter("@total", _total));
                    cmdCreateBill.Parameters.Add(new SqlParameter("@staffId", _staffId));
                    cmdCreateBill.Parameters.Add(new SqlParameter("@customerId", _customerId));

                    int rowsAffected = cmdCreateBill.ExecuteNonQuery();
                    int billId = (int)returnParameter.Value;
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
                        xlWorkSheet.Cells[1, 1] = "HOÁ ĐƠN";

                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[4, 3]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[4, 3]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[4, 1] = "Mã NV: " + _staffId;

                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 4], xlWorkSheet.Cells[4, 5]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 4], xlWorkSheet.Cells[4, 5]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[4, 4] = "Mã KH: " + _customerId;

                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 6], xlWorkSheet.Cells[4, 8]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[4, 6], xlWorkSheet.Cells[4, 8]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[4, 6] = "Ngày tạo: " + DateTime.Today.ToString("dd-MM-yyyy");

                        xlWorkSheet.Cells[6, 1] = "Mã sách";
                        xlWorkSheet.Cells[6, 2] = "Tên sách";
                        xlWorkSheet.Cells[6, 3] = "Thể loại";
                        xlWorkSheet.Cells[6, 4] = "Ngày xuất bản";
                        xlWorkSheet.Cells[6, 5] = "Đơn giá";
                        xlWorkSheet.Cells[6, 6] = "Tác giả";
                        xlWorkSheet.Cells[6, 7] = "Nhà xuất bản";
                        xlWorkSheet.Cells[6, 8] = "Số lượng";
                        int rowIndex = 7;

                        foreach (Book book in books)
                        {
                            SqlCommand cmdInsertBookToBill = new SqlCommand("addBookToBill", _connection)
                            {
                                CommandType = CommandType.StoredProcedure
                            };

                            cmdInsertBookToBill.Parameters.Add(new SqlParameter("@bookId", book.ID));
                            cmdInsertBookToBill.Parameters.Add(new SqlParameter("@count", book.Count));
                            cmdInsertBookToBill.Parameters.Add(new SqlParameter("@dateCreate", DateTime.Today));

                            if (cmdInsertBookToBill.ExecuteNonQuery() < 3)
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

                        rowIndex = rowIndex + 3;
                        xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 7], xlWorkSheet.Cells[rowIndex, 8]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 7], xlWorkSheet.Cells[rowIndex, 8]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[rowIndex, 7] = "Thành tiền: " + _total;
                        rowIndex++;
                        xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 7], xlWorkSheet.Cells[rowIndex, 8]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 7], xlWorkSheet.Cells[rowIndex, 8]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        int received = _total - _due;
                        xlWorkSheet.Cells[rowIndex, 7] = "Đã nhận: " + received;
                        rowIndex++;
                        xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 7], xlWorkSheet.Cells[rowIndex, 8]].Merge();
                        xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 7], xlWorkSheet.Cells[rowIndex, 8]].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Cells[rowIndex, 7] = "Còn nợ: " + _due;

                        xlWorkSheet.Columns.AutoFit();

                        if (!Directory.Exists(billPath))
                        {
                            Directory.CreateDirectory(billPath);
                        }

                        xlWorkBook.SaveAs(billPath + "HD" + billId + ".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        Marshal.ReleaseComObject(xlWorkSheet);
                        Marshal.ReleaseComObject(xlWorkBook);
                        Marshal.ReleaseComObject(xlApp);

                        e.Result = billPath + "HD" + billId + ".xlsx";

                        if (_due != 0)
                        {
                            SqlCommand cmdInsertIndebtednessInfo = new SqlCommand("addIndebtednessInfo", _connection)
                            {
                                CommandType = CommandType.StoredProcedure
                            };

                            cmdInsertIndebtednessInfo.Parameters.Add(new SqlParameter("@customerId", _customerId));
                            cmdInsertIndebtednessInfo.Parameters.Add(new SqlParameter("@dateCreate", DateTime.Today));
                            cmdInsertIndebtednessInfo.Parameters.Add(new SqlParameter("@due", Math.Abs(_due)));
                            if (cmdInsertIndebtednessInfo.ExecuteNonQuery() < 3)
                                sqlWorker.CancelAsync();
                        }

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
    }
}
