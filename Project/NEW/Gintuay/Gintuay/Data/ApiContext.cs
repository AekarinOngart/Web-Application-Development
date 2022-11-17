using Microsoft.EntityFrameworkCore;
using Gintuay.Models;


namespace Gintuay.Data
   
{
    public class ApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { 
        
        }
    }
}
