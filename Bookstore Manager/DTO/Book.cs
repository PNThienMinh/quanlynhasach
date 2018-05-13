using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Book
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Cost { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Identifier { get; set; }
        public int Count { get; set; } = 0;
        public int Inventory { get; set; } = 0;

    }
}