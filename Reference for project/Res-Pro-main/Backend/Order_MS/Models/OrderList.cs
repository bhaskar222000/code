using System.ComponentModel.DataAnnotations;

namespace Order_MS.Models
{
    public class OrderList
    {
        [Key]
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Rating { get; set; }
        public float TotalPrice { get; set; }
    }
}
