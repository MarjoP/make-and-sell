namespace MaterialStorage.Models
{
    public class RawMaterialStock
    {
        public int Id { get; set; }
        public RawMaterial RawMaterial { get; set; }
        public int Quantity { get; set; }
    }
}
