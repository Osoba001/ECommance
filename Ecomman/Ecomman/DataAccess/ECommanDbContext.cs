using Ecomman.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecomman.DataAccess
{
    public class ECommanDbContext:DbContext
    {
        public ECommanDbContext(DbContextOptions<ECommanDbContext> options):base(options) 
        {
            
        }

        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Ecomman.Models.OrderDetail> OrderDetail { get; set; } = default!;
    }
}
