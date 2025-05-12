using System.ComponentModel.DataAnnotations.Schema;

namespace Kemet.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate {  get; set; }
        public double TotalAmount { get; set; }
        public string? OrderState { get; set; }
        public string? PaymentMethod { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
       
    }
}
