using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DatabaseModel
{
    public class ExcelFileHandler
    {
        private static SqlConnection _connection;

        public static void InsertBookToDb(Book book)
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
                    cmdUpdate.Parameters.Add(new SqlParameter("@bookType", book.Type));
                    cmdUpdate.Parameters.Add(new SqlParameter("@datePublished", book.PublishedDate));
                    cmdUpdate.Parameters.Add(new SqlParameter("@price", book.Cost));
                    cmdUpdate.Parameters.Add(new SqlParameter("@authorName", book.Author));
                    cmdUpdate.Parameters.Add(new SqlParameter("@publisher", book.Publisher));


                    int rowsAffected = cmdUpdate.ExecuteNonQuery();

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
