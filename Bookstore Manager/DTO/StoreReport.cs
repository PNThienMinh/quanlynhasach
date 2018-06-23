using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StoreReport
    {
        public int NumBookImport { get; set; }
        public int NumBookInStock { get; set; }
        public int Revenue { get; set; }
        public int NumBookSold { get; set; }
    }
}
