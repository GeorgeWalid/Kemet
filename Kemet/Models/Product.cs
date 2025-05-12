using System.ComponentModel.DataAnnotations.Schema;

namespace Kemet.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string? ProductDescription { get; set; }
        public double Price { get; set; }
        public int  Stock { get; set; }
        public string imageURL { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("ShoppingCart")]
        public int CartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }



    }
}
