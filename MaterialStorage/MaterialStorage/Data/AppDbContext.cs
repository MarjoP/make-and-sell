using MaterialStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialStorage.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<RawMaterialStock> RawMaterialStocks { get; set; }
        public DbSet<BOM> BOMs { get; set; }
    }
}
