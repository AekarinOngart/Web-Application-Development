using Microsoft.EntityFrameworkCore;
using Gintuay.Models;


namespace Gintuay.Data
   
{
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BuyOrder> BuyOrders { get; set; }
        public DbSet<PickupOrder> PickupOrders { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Addon> Addons { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { 
        
        }
    }
}
