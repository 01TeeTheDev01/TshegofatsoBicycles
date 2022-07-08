using catalog.api.Models;
using catalog.api.Services;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace catalog.api.tests
{
    [TestClass]
    public class CatalogTests
    {
        private IProductRepository productActions;

        [TestMethod]
        public void GetProducts_ProductData_IsAvailable()
        {
            try
            {
                productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext(), new Product());
                var result = productActions.GetProducts();
                Assert.IsNotNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void GetProducts_ProductData_IsUnAvailable()
        {
            try
            {
                productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.GetProductsAsync();

                Assert.IsNull(result.Result);

            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void AddProduct_WithFullParameters_IsValid()
        {
            try
            {
                productActions = new(new ProductRepository(
                new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.AddProductAsync("Raleigh", "Mongoose", "BMX", "Red", 17, 1599m);
                Assert.IsNotNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void AddProduct_WithIncompleteParameters_IsNotValid()
        {
            try
            {
                ProductActions productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.AddProductAsync(null, "Mongoose", "BMX", null, 0, 0.0m);
                Assert.IsNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void SearchById_ProductExist_IsTrue()
        {
            try
            {
                ProductActions productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.SearchByBrandAsync("Raleigh");
                Assert.IsNotNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void SearchById_ProductExist_IsFalse()
        {
            try
            {
                ProductActions productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.SearchByBrandAsync("Pireless");
                Assert.IsNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void SearchByWheelSize_ProductExist_IsTrue()
        {
            try
            {
                ProductActions productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.SearchByWheelSizeAsync(17);
                Assert.IsNotNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void SearchByWheelSize_ProductExist_IsFalse()
        {
            try
            {
                ProductActions productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.SearchByWheelSizeAsync(30);
                Assert.IsNull(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void DeleteById_IsDeleted_IsTrue()
        {
            try
            {
                productActions = new(new ProductRepository(new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.DeleteById("58s497sa67a58s");
                Assert.IsTrue(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [TestMethod]
        public void DeleteById_IsDeleted_IsFalse()
        {
            try
            {
                productActions = new(
                new ProductRepository(
                    new Services.CatalogDbContext.CatalogDbContext()), new Product());
                var result = productActions.DeleteByIdAsync("Raleigh");
                Assert.IsFalse(result.Result);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

    }
}
