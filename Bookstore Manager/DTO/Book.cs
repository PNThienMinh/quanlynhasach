using System;
namespace DTO
{
    public class Book
    {
        public int ID { get; set; }
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