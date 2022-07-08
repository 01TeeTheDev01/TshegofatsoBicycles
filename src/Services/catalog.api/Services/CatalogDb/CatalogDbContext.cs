using System;

using catalog.api.Models;

using Microsoft.EntityFrameworkCore;

namespace catalog.api.Services.CatalogDbContext
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public CatalogDbContext(DbContextOptions<CatalogDbContext> dbContext) : base(dbContext)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasData(new Product 
                { 
                    Brand = "Raleigh", 
                    Color = "Black",
                    Model = "Mongoose", 
                    Price = 1_799.99m, 
                    Style = "BMX",
                    WheelSize = 17
                });

            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    Brand = "Raleigh",
                    Color = "Red",
                    Model = "Panther",
                    Price = 2_499.99m,
                    Style = "RACING",
                    WheelSize = 22
                });

            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    Brand = "Armstrong",
                    Color = "Silver",
                    Model = "Mongoose",
                    Price = 2_999.99m,
                    Style = "RACING",
                    WheelSize = 22
                });

            modelBuilder.Entity<Product>()
               .HasData(new Product
               {
                   Brand = "Peagot",
                   Color = "Silver-Gray",
                   Model = "Sprinter-X2",
                   Price = 1_299.99m,
                   Style = "BMX",
                   WheelSize = 17
               });
        }
    }
}
