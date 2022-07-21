using catalog.api.Models;

using Microsoft.EntityFrameworkCore;

namespace catalog.api.Services.CatalogDbContext
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public CatalogDbContext(DbContextOptions<CatalogDbContext> dbContext) 
            : base(dbContext)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>();
        }
    }
}
