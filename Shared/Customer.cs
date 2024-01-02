using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.Shared
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // hashed password
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Navigation property
        public ICollection<Order> Orders { get; set; }
    }
}
