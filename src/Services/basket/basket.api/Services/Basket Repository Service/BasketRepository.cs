namespace basket.api.Services.Basket_Repository_Service
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using basket.api.Models;

    using BasketDatabaseContext;

    using catalog.api.Models;

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
            var basket = await basketDbContext.Basket.FirstOrDefaultAsync(basket => basket.BasketId == Guid.Parse(id));

            return basket;
        }

        public async Task<IEnumerable<Basket>> GetBaskets()
        {
            var baskets = await basketDbContext.Basket.ToListAsync();

            return baskets;
        }
    }
}
