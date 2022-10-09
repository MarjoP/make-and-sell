namespace MaterialStorage.Models
{
    public class BOM
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public int RawMaterialId { get; set; }
        public int Quantity { get; set; }
    }
}
