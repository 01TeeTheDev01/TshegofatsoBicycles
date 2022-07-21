using System.Collections.Generic;
using System.Threading.Tasks;

using catalog.api.Models;

namespace catalog.api.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> AddProduct(Product product);
        Task<IEnumerable<Product>> SearchByWheelSize(int wheelSize);
        Task<IEnumerable<Product>> SearchByBrand(string brand);
        Task<IEnumerable<Product>> SearchByColor(string color);
        Task<IEnumerable<Product>> SearchByPrice(decimal price);
        Task<bool> DeleteById(string id);
    }
}
