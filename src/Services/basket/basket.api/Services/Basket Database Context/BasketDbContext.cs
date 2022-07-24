using basket.api.Models;

using Microsoft.EntityFrameworkCore;

namespace basket.api.Services.BasketDatabaseContext
{
    public class BasketDbContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }

        public BasketDbContext(DbContextOptions<BasketDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Basket>();
        }
    }
}
