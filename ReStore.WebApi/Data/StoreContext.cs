using Microsoft.EntityFrameworkCore;
using ReStore.WebApi.Entities;

namespace ReStore.WebApi.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}