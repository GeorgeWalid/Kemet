using Microsoft.AspNetCore.Identity;

namespace Kemet.Models
{
    public class User: IdentityUser
    {
        
        
            public string UserFullName { get; set; }
            public string Role { get; set; }
            // public ICollection<Order> Orders { get; set; }
            //public ICollection<ShoppingCart> ShoppingCarts { get; set; }
        
    }
}
