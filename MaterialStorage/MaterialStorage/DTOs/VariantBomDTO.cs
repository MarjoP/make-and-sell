namespace MaterialStorage.DTOs
{
    public class VariantBomDTO
    {
        public int VariantId { get; set; }
        public Dictionary<int,int> Materials { get; set; }
    }
}
