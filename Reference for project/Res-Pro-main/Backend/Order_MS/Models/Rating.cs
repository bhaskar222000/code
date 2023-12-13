using System.ComponentModel.DataAnnotations;

namespace Order_MS.Models
{
    public class Rating
    {
        [Key]
        public int RateId { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public float Rate { get; set; }
    }
}
