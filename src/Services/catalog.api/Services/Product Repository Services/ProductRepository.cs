using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using catalog.api.Models;

using Microsoft.EntityFrameworkCore;

namespace catalog.api.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogDbContext.CatalogDbContext catalogDbContext;

        public ProductRepository(CatalogDbContext.CatalogDbContext catalogDbContext)
        {
            this.catalogDbContext = catalogDbContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var result = await catalogDbContext.Products.AddAsync(product);

            await catalogDbContext.SaveChangesAsync();

            return await Task.FromResult(result.Entity);
        }

        public async Task<bool> DeleteById(string id)
        {
            var result = await catalogDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (result != null)
            {
                catalogDbContext.Products.Remove(result);

                await catalogDbContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await catalogDbContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchByBrand(string brand)
        {
            var result = await catalogDbContext.Products.Where(p => p.Brand == brand).ToListAsync();

            if (result != null)
                return await Task.FromResult(result);

            return null;
        }

        public async Task<IEnumerable<Product>> SearchByWheelSize(int wheelSize)
        {
            var result = await catalogDbContext.Products.Where(p => p.WheelSize == wheelSize).ToListAsync();

            if (result != null)
                return await Task.FromResult(result);

            return null;
        }
    }
}
