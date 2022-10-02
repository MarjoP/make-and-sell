namespace MaterialStorage.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? path { get; set; }
        public Variant? Variant { get; set; }
        public Product? Product { get; set; }
        public bool isProductImage { get; set; }
    }
}
