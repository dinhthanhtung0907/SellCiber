using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BackEnd.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
