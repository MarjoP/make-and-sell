namespace MaterialStorage.Models
{
    public class Variant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int AlertLimit { get; set; }
    }
}
