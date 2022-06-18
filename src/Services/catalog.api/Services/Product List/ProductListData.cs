using catalog.api.Models;
using System.Collections.Generic;
using System;

namespace catalog.api.Services.Product_List
{
    public class ProductListData
    {
        internal static List<Product> Products => new()
        {
            new Product() { Id = Guid.NewGuid().ToString(), Brand = "Raleigh", Color = "Red", Model = "Mongoose", Style = "BMX", Wheels = 2, Price = 1799.99m, WheelSize = 17 },
            new Product() { Id = Guid.NewGuid().ToString(), Brand = "Peugot", Color = "Lime", Model = "Power", Style = "Racing", Wheels = 2, Price = 2299.99m, WheelSize = 20 },
            new Product() { Id = Guid.NewGuid().ToString(), Brand = "Raleigh", Color = "Yellow", Model = "ZX78H", Style = "Mountain", Wheels = 2, Price = 1499.99m, WheelSize = 22 },
            new Product() { Id = Guid.NewGuid().ToString(), Brand = "Armstrong", Color = "Red", Model = "Mongoose", Style = "BMX", Wheels = 2, Price = 1899.99m, WheelSize = 17 }
        };
    }
}
