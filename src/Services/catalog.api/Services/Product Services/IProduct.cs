using System.Collections.Generic;
using System.Threading.Tasks;

using catalog.api.Models;

namespace catalog.api.Services
{
    public interface IProduct
    {
        Task<IReadOnlyCollection<Product>> GetProducts();
        Task<Product> AddProduct(Product product);
        Task<IReadOnlyCollection<Product>> SearchByWheelSize(int wheelSize);
        Task<IReadOnlyCollection<Product>> SearchByBrand(string brand);
        Task<bool> DeleteById(string id);
    }
}
