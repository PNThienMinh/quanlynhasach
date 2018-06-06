using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStallService
    {
        
        void ExportBill(int staffId, Customer customer, List<Book> books, int total, int due);
    }
}
