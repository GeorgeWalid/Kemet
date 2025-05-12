using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kemet.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public double Totalprice { get; set; }
        //[ForeignKey("User")]
       // public int Id { get; set; }
        //public User User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
