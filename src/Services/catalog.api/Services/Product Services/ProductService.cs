using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using catalog.api.Models;
using catalog.api.Services.CatalogDbContext;

namespace catalog.api.Services
{
    public class ProductService : IProduct
    {
        private readonly DbContext dbContext;


        public ProductService(DbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Product> AddProduct(Product product)
        {
            if (product != null)
            {
                if (!string.IsNullOrEmpty(product.Id) && !string.IsNullOrWhiteSpace(product.Id) &&
                    !string.IsNullOrEmpty(product.Brand) && !string.IsNullOrWhiteSpace(product.Id) &&
                    !string.IsNullOrEmpty(product.Model) && !string.IsNullOrWhiteSpace(product.Id) &&
                    !string.IsNullOrEmpty(product.Style) && !string.IsNullOrWhiteSpace(product.Id) &&
                    !string.IsNullOrEmpty(product.Color) && !string.IsNullOrWhiteSpace(product.Id) &&
                    product.Price > 0.0m)
                {
                    return await Task.FromResult(DbContext.AddProduct(product).Result);
                }
            }

            return null;
        }

        public async Task<bool> DeleteById(string id)
        {
            return await Task.FromResult(DbContext.DeleteById(id).Result);
        }

        public async Task<IReadOnlyCollection<Product>> GetProducts()
        {
            return await Task.FromResult(dbContext.GetProducts().Result);
        }

        public async Task<IReadOnlyCollection<Product>> SearchByBrand(string brand)
        {
            return await Task.FromResult(dbContext.SearchByBrand(brand).Result);
        }

        public async Task<IReadOnlyCollection<Product>> SearchByWheelSize(int wheelSize)
        {
            return await Task.FromResult(dbContext.SearchByWheelSize(wheelSize).Result);
        }
    }
}
