namespace MaterialStorage.Models
{
    public class BOM
    {
        public int Id { get; set; }
        public Variant Variant { get; set; }
        public RawMaterial RawMaterial { get; set; }
        public int Quantity { get; set; }
    }
}
