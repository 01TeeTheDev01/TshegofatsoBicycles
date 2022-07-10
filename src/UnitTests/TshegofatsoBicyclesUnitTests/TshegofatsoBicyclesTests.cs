using System.Collections.Generic;
using System;

using catalog.api.Models;
using catalog.api.Services;
using catalog.api.Services.CatalogDbContext;

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

namespace TshegofatsoBicyclesUnitTests
{
    [TestClass]
    public class TshegofatsoBicyclesCatalogUnitTests
    {
        IProductRepository _productRepository;

        Mock MockSet = new Mock<DbSet<Product>>();
        [SetUp]
        public void Setup()
        {
                    var persons = new List<Person>() {
                new Person() { TaxCode = "taxcode1", Firstname = "firstname1", Surname = "surname1" },
                new Person() { TaxCode = "taxcode2", Firstname = "firstname2", Surname = "surname2" }
        };
                    var queryable = persons.AsQueryable();
        }

        [TestMethod]
        public async void Products_GetProducts_IsTrue()
        {
            MockSet.
            _productRepository = new ProductRepository(null);

            var result = await _productRepository.GetProducts();

            Assert.IsNotNull(result);
        }
    }
}
