using System;
namespace DTO
{
    public class IndebtednessReport
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Time { get; set; }
        public int InEarly { get; set; }
        public int OnArise { get; set; }
        public int InLast { get; set; }
    }
}
