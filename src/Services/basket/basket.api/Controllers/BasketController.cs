using System.Threading.Tasks;

using basket.api.Models;
using basket.api.Services.Basket_Repository_Service;

using Microsoft.AspNetCore.Mvc;

namespace basket.api.Controllers
{
    [ApiController]
    public class BasketController : Controller
    {
        private readonly IBasketRepsoitory basketReposiotry;

        public BasketController(IBasketRepsoitory basketReposiotry)
        {
            this.basketReposiotry = basketReposiotry;
        }


        [HttpGet]
        [Route("api/GetBasket/{id}")]
        public async Task<ActionResult<Basket>> GetBasket(string id)
        {
            return await basketReposiotry.GetBasket(id);
        }
    }
}
