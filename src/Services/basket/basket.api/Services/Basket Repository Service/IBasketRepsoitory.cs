using System.Collections.Generic;
using System.Threading.Tasks;

using basket.api.Models;

using catalog.api.Models;

namespace basket.api.Services.Basket_Repository_Service
{
    public interface IBasketRepsoitory
    {
        Task<IEnumerable<Basket>> GetBaskets();
        Task<Basket> GetBasket(string id);
    }
}
