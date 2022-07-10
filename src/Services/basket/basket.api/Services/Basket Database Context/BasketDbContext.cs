using basket.api.Models;

using Microsoft.EntityFrameworkCore;

using catalog.api.Models;
using System.Collections.Generic;

namespace basket.api.Services.BasketDatabaseContext
{
    public class BasketDbContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }

        public BasketDbContext(DbContextOptions<BasketDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Basket>().HasData(
                new Basket
                {
                    BasketItems = new List<Product>
                    {
                        new Product
                        {
                            
                        }
                    }

                });

            modelBuilder.Entity<Basket>().HasData(
                new Basket
                {

                });

            modelBuilder.Entity<Basket>().HasData(
                new Basket
                {

                });

            modelBuilder.Entity<Basket>().HasData(
                new Basket
                {

                });
        }
    }
}
