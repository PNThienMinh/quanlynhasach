using System;
namespace DTO
{
    public class InventoryReport
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public DateTime Time { get; set; }
        public int InEarly { get; set; }
        public int OnArise { get; set; }
        public int InLast { get; set; }
    }
}
