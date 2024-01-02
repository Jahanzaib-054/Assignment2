using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.Shared
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        // Foreign key
        public int CategoryID { get; set; }

        // Navigation properties
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
