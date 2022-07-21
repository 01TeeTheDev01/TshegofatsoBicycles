using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using catalog.api.Models;

namespace basket.api.Models
{
    public class Basket
    {
        public Guid BasketId { get; set; } = Guid.NewGuid();

        public Product BasketItem { get; set; } = null;

        public decimal BasketTotalPrice { get; set; } = 0.0m;
    }
}
