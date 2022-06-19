using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using catalog.api.Models;
using catalog.api.Services;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catalog.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ProductActions productActions;

        public ProductsController(ProductActions productActions)
        {
            this.productActions = productActions ?? throw new ArgumentNullException(nameof(productActions));
        }


        // GET: api/<ProductsController>
        [HttpGet]
        [Route("GetProducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await productActions.GetProductsAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet()]
        [Route("SearchByBrand/{brand}")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByBrand(string brand)
        {
            var result = await productActions.SearchByBrandAsync(brand);

            if (result == null)
                return NotFound($"We don't have a product with the name of '{brand}' in our catalog. ");

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet()]
        [Route("SearchByWheelSize/{wheelSize}")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByWheelSize(int wheelSize)
        {
            var result = await productActions.SearchByWheelSizeAsync(wheelSize);

            if (result == null)
                return NotFound($"We don't have a product with wheel size of '{wheelSize}\"' in stock. ");

            return Ok(result);
        }


        // POST api/<ProductsController>
        [HttpPost]
        [Route("AddProduct/{brand}/{model}/{style}/{color}/{wheelSize}/{price}")]
        public async Task<ActionResult<Product>> AddProduct(string brand, string model, string style, string color, int wheelSize, decimal price)
        {
            var result = await productActions.AddProductAsync(brand, model, style, color, wheelSize, price);

            if (result == null)
                return BadRequest($"Failed to add {result} to database.");

            return Ok($"{result} has been added to the database");
        }


        // DELETE api/<ProductsController>/5
        [HttpDelete()]
        [Route("DeleteById/{id}")]
        public async Task<ActionResult<bool>> DeleteById(string id)
        {
            var result = await productActions.DeleteByIdAsync(id);

            if (!result)
                return NotFound($"Product with Id = '{id}' does not exist in the catalog.");

            return Ok($"Product with Id = '{id}' has been removed from the catalog.");
        }
    }
}
