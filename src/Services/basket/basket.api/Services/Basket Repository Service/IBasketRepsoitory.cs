using System.Threading.Tasks;

using basket.api.Models;

namespace basket.api.Services.Basket_Repository_Service
{
    public interface IBasketRepsoitory
    {
        Task<Basket> GetBasket(string id);
    }
}
