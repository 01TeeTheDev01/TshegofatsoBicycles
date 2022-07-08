﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using catalog.api.Services.CatalogDbContext;

namespace catalog.api.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    partial class CatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("catalog.api.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WheelSize")
                        .HasColumnType("int");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "27d3443e-288a-4a7e-a6bb-c0e0f6ef11fc",
                            Brand = "Raleigh",
                            Color = "Black",
                            Model = "Mongoose",
                            Price = 1799.99m,
                            Style = "BMX",
                            WheelSize = 17,
                            Wheels = 2
                        },
                        new
                        {
                            Id = "4ab61802-e7ef-4a4e-ada7-5fb2d0759aa0",
                            Brand = "Raleigh",
                            Color = "Red",
                            Model = "Panther",
                            Price = 2499.99m,
                            Style = "RACING",
                            WheelSize = 22,
                            Wheels = 2
                        },
                        new
                        {
                            Id = "c506a5ef-404f-4e19-9f97-d3a446209782",
                            Brand = "Armstring",
                            Color = "Silver",
                            Model = "Mongoose",
                            Price = 2999.99m,
                            Style = "RACING",
                            WheelSize = 22,
                            Wheels = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
