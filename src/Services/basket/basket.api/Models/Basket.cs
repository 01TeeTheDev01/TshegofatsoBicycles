using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using catalog.api.Models;

namespace basket.api.Models
{
    public class Basket
    {
        public Task<IEnumerable<Product>> BasketItems { get; set; } = null;
        public string BasketId { get; set; } = Guid.NewGuid().ToString();
        public decimal BasketTotalPrice { get; set; } = 0.0m;
    }
}
