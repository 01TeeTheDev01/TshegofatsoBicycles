using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using catalog.api.Models;
using catalog.api.Services;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catalog.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        // GET: api/<ProductsController>
        [HttpGet("GetProducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await productRepository.GetProducts();

            if (result == null)
                return NoContent();

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet("SearchByBrand")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByBrand(string brand)
        {
            var result = await productRepository.SearchByBrand(brand);

            if (result == null)
                return NotFound($"We don't have a product with the name of '{brand}' in our catalog. ");

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet("SearchByWheelSize")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByWheelSize(int wheelSize)
        {
            var result = await productRepository.SearchByWheelSize(wheelSize);

            if (result == null)
                return NotFound($"We don't have a product with wheel size of '{wheelSize}\"' in stock. ");

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet("SearchByColor")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByColor(string color)
        {
            var result = await productRepository.SearchByColor(color);

            if (result == null)
                return NotFound($"We don't have a product with a color of '{color}\"' in stock. ");

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet("SearchByPrice")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByPrice(decimal price)
        {
            var result = await productRepository.SearchByPrice(price);

            if (result == null)
                return NotFound($"We don't have a product with a price of '{price}\"' in stock. ");

            return Ok(result);
        }


        // POST api/<ProductsController>
        [HttpPost("AddProduct")]
        public async Task<ActionResult<Product>> AddProduct(string brand, string model, string style, string color, int wheelSize, decimal price)
        {
            var result = await productRepository.AddProduct(new Product 
            { 
                Brand = brand, 
                Model = model, 
                Style = style, 
                Color = color, 
                WheelSize = wheelSize, 
                Price = price
            });

            if (result == null)
                return BadRequest($"Product Id = '{result.Id}': {result.Brand}-{result.Model} was not added to the database");

            return Ok($"Product Id = '{result.Id}': {result.Brand}-{result.Model} has been added to the database");
        }


        // DELETE api/<ProductsController>/5
        [HttpDelete("DeleteById")]
        public async Task<ActionResult<bool>> DeleteById(string id)
        {
            var result = await productRepository.DeleteById(id);

            if (!result)
                return NotFound($"Product with Id = '{id}' not found in catalog.");

            return Ok($"Product with Id = '{id}' has been removed from the catalog.");
        }
    }
}
