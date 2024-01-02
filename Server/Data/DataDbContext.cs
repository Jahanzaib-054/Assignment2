using APIAssignment.Shared;
using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Server.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)  
        {
            
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> ordersItems { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; } 
    }
}
