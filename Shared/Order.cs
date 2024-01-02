﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.Shared
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
