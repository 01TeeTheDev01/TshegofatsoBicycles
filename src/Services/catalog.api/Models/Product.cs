namespace catalog.api.Models
{
    public class Product
    {
        public string Id { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public int Wheels { get; set; } = 0;
        public int WheelSize { get; set; } = 0;
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
    }
}
