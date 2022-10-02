using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStorage.Models
{
    public class RawMaterial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Unit { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal LatestPricePerUnit { get; set; }


    }
}
