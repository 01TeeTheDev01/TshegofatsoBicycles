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
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        // GET: api/<ProductsController>
        [HttpGet]
        [Route("GetProducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await productRepository.GetProducts();

            if (result == null)
                return NoContent();

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet]
        [Route("SearchByBrand/{brand}")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByBrand(string brand)
        {
            var result = await productRepository.SearchByBrand(brand);

            if (result == null)
                return NotFound($"We don't have a product with the name of '{brand}' in our catalog. ");

            return Ok(result);
        }


        // GET api/<ProductsController>/5
        [HttpGet]
        [Route("SearchByWheelSize/{wheelSize}")]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> SearchByWheelSize(int wheelSize)
        {
            var result = await productRepository.SearchByWheelSize(wheelSize);

            if (result == null)
                return NotFound($"We don't have a product with wheel size of '{wheelSize}\"' in stock. ");

            return Ok(result);
        }


        // POST api/<ProductsController>
        [HttpPost]
        [Route("AddProduct/{brand}/{model}/{style}/{color}/{wheelSize}/{price}")]
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
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public async Task<ActionResult<bool>> DeleteById(string id)
        {
            var result = await productRepository.DeleteById(id);

            if (!result)
                return NotFound($"Product with Id = '{id}' not found in catalog.");

            return Ok($"Product with Id = '{id}' has been removed from the catalog.");
        }
    }
}
