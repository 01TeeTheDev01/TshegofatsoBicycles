using catalog.api.Models;
using catalog.api.Services;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace catalog.api.tests
{
    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        public void GetProducts()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.GetProductsAsync();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddProduct_WithFullParameters_IsValid()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.AddProductAsync("Raleigh", "Mongoose", "BMX", "Red", 17, 1599.99m);
            Assert.IsNotNull(result.Result);
        }


        [TestMethod]
        public void AddProduct_WithIncompleteParameters_IsNotValid()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.AddProductAsync(null, "Mongoose", "BMX", null, 0, 0.0m);
            Assert.IsNull(result.Result);
        }


        [TestMethod]
        public void SearchById_ProductExist_IsTrue()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.SearchByBrandAsync("Raleigh");
            Assert.IsNotNull(result.Result);
        }


        [TestMethod]
        public void SearchById_ProductExist_IsFalse()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.SearchByBrandAsync("Pireless");
            Assert.IsNull(result.Result);
        }


        [TestMethod]
        public void SearchByWheelSize_ProductExist_IsTrue()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.SearchByWheelSizeAsync(17);
            Assert.IsNotNull(result.Result);
        }


        [TestMethod]
        public void SearchByWheelSize_ProductExist_IsFalse()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.SearchByWheelSizeAsync(30);
            Assert.IsNull(result.Result);
        }


        [TestMethod]
        public void DeleteById_IsDeleted_IsTrue()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.DeleteByIdAsync("Raleigh");
            Assert.IsTrue(result.Result);
        }


        [TestMethod]
        public void DeleteById_IsDeleted_IsFalse()
        {
            ProductActions productActions = new(new ProductService(), new Product());
            var result = productActions.DeleteByIdAsync("Raleigh");
            Assert.IsFalse(result.Result);
        }

    }
}
