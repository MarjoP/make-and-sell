using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialStorage.Models
{
    public class Variant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public int AlertLimit { get; set; }
        public List<Image> Images { get; set; }    
    }
}
