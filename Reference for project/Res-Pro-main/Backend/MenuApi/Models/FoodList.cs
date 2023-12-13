using System.ComponentModel.DataAnnotations;

namespace Menu_MS.Models
{
    public class FoodList01
    {
        [Key]
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Product_Category { get; set; }
        public float Product_Rating { get; set; }
        public float Product_Price { get; set; }
        public int Product_Quantity { get; set; }
        public string Product_Image { get; set; }
        public int Empty1 { get; set; }
 
    }
}
