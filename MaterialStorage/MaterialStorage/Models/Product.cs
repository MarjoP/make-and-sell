namespace MaterialStorage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Variant>? Variants { get; set; }
        public List<Image>? Images { get; set; }

    }
}
