namespace basket.api.Services.Basket_Repository_Service
{
    using System.Threading.Tasks;

    using basket.api.Models;

    using BasketDatabaseContext;

    using Microsoft.EntityFrameworkCore;

    public class BasketRepository : IBasketRepsoitory
    {
        private readonly BasketDbContext basketDbContext;

        public BasketRepository(BasketDbContext basketDbContext)
        {
            this.basketDbContext = basketDbContext;
        }

        public async Task<Basket> GetBasket(string id)
        {
            return await basketDbContext.Baskets.FirstOrDefaultAsync(basket => basket.BasketId == id);
        }
    }
}
