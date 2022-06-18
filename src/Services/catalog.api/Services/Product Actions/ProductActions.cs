using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using catalog.api.Models;

namespace catalog.api.Services
{
    public class ProductActions
    {
        private readonly IProduct _product;

        private readonly Product productObject;

        public ProductActions()
        {

        }

        public ProductActions(IProduct product, Product productObject)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            this.productObject = productObject ?? throw new ArgumentNullException(nameof(productObject));
        }

        public async Task<IReadOnlyCollection<Product>> GetProductsAsync()
        {
            return await _product.GetProducts();
        }

        public async Task<Product> AddProductAsync(string brand, string model, string style, string color, int wheelSize, decimal price)
        {
            productObject.Id = Guid.NewGuid().ToString();
            productObject.Brand = brand;
            productObject.Model = model;
            productObject.Style = style;
            productObject.Color = color;
            productObject.Wheels = 2;
            productObject.WheelSize = wheelSize;
            productObject.Price = price;

            return await _product.AddProduct(productObject);
        }

        public async Task<IReadOnlyCollection<Product>> SearchByBrandAsync(string brand)
        {
            return await _product.SearchByBrand(brand);
        }

        public async Task<IReadOnlyCollection<Product>> SearchByWheelSizeAsync(int wheelSize)
        {
            return await _product.SearchByWheelSize(wheelSize);
        }

        public async Task<bool> DeleteByIdAsync(string id)
        { 
            return await _product.DeleteById(id);
        }
    }
}
