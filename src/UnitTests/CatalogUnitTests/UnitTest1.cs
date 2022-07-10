using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

using catalog.api.Models;

using Microsoft.EntityFrameworkCore;

using Moq;

using NUnit.Framework;

namespace CatalogUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var product = new List<Product>()
            {
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
                new Product{ Brand = "Raleigh", Color = "Red", Model = "X432-Z", Price = 1799.99m, Style = "BMX", WheelSize = 17 },
            };

            var q = product.AsQueryable();

            var mockSet = new Mock<DbSet<Product>>();

            mockSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(q.Expression);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}