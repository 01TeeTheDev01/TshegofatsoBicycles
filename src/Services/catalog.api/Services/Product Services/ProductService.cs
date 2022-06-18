using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using catalog.api.Models;

namespace catalog.api.Services
{
    public class ProductService : IProduct
    {
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
                    Product_List.ProductListData.Products.Add(product);
                    return await Task.FromResult(product);
                }
            }

            return null;
        }

        public async Task<bool> DeleteById(string id)
        {
            var productToRemove = Product_List.ProductListData.Products.FirstOrDefault(p => p.Id == id);

            if (productToRemove != null)
            {
                var result = Product_List.ProductListData.Products.Remove(productToRemove);

                return await Task.FromResult(result);
            }

            return false;
        }

        public async Task<IReadOnlyCollection<Product>> GetProducts()
        {
            var result = await Task.FromResult(Product_List.ProductListData.Products);

            if (result.Any())
                return result;

            return null;
        }

        public async Task<IReadOnlyCollection<Product>> SearchByBrand(string brand)
        {
            var result = Product_List.ProductListData.Products.Where(b => b.Brand.Equals(brand));

            if (result.Any())
                return await Task.FromResult(result.ToList());

            return null;
        }

        public async Task<IReadOnlyCollection<Product>> SearchByWheelSize(int wheelSize)
        {
            var result = Product_List.ProductListData.Products.Where(w => w.WheelSize == wheelSize);

            if (result.Any())
                return await Task.FromResult(result.ToList());

            return null;
        }
    }
}
