namespace MaterialStorage.Models
{
    public class RawMaterial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal LatestPricePerUnit { get; set; }


    }
}
