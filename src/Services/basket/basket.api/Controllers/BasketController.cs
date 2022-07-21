using System.Collections.Generic;
using System.Threading.Tasks;

using basket.api.Models;
using basket.api.Services.Basket_Repository_Service;

using Microsoft.AspNetCore.Mvc;

namespace basket.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BasketController : Controller
    {
        private readonly IBasketRepsoitory basketReposiotry;

        public BasketController(IBasketRepsoitory basketReposiotry)
        {
            this.basketReposiotry = basketReposiotry;
        }


        [HttpGet("getBasket")]
        public async Task<ActionResult<IEnumerable<Basket>>> GetBaskets()
        {
            var result = await basketReposiotry.GetBaskets();

            if (result == null)
                return NoContent();

            if (result != null && !result.GetEnumerator().MoveNext())
                return NoContent();

            return Ok(result);
        }

        [HttpGet("getBasket/{id}")]
        public async Task<ActionResult<Basket>> GetBasket(string id)
        {
            try
            {
                var result = await basketReposiotry.GetBasket(id);

                if (result == null)
                    return NotFound($"We don't have BasketId='{result.BasketId}' in our catalog. ");

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Message => {ex.Message}");
            }
        }
    }
}
