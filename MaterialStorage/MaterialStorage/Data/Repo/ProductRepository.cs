using MaterialStorage.DTOs;
using MaterialStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialStorage.Data.Repo
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task AddNewProductAsync(Product product)
        {
            await _appDbContext.Products.AddAsync(product);  
        }

        public async Task AddNewVariantAsync(Variant variant)
        {
            await _appDbContext.Variants.AddAsync(variant);
        }

        public async Task AddVariantMaterialsAsync(VariantBomDTO variantMaterials)
        {
            foreach(var material in variantMaterials.Materials)
            {
                var bom = new BOM
                {
                    VariantId = variantMaterials.VariantId,
                    RawMaterialId = material.Key,
                    Quantity = material.Value
                };
                await _appDbContext.BOMs.AddAsync(bom);
            }
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _appDbContext.Products.Include(x => x.Variants).ToListAsync();
        }

        public async Task<IEnumerable<Variant>> GetAllVariantsAsync()
        {
           return await _appDbContext.Variants.ToListAsync();
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            return await _appDbContext.Products.FindAsync(productId);
        }

        public async Task<Variant> GetVariantAsync(int variantId)
        {
            return await _appDbContext.Variants.FindAsync(variantId);
        }

        public async Task<int> GetVariantStockAmountAsync(int variantId)
        {
            var variant = await _appDbContext.VariantStocks.FindAsync(variantId);

            return variant != null ? variant.Quantity : 0;
        }

        public void UpdateProduct(Product product)
        {
             _appDbContext.Entry(product).State = EntityState.Modified;
        }

        public void UpdateVariant(Variant variant)
        {
            _appDbContext.Entry(variant).State = EntityState.Modified;
        }

        public void UpdateVariantMaterials(VariantBomDTO materials)
        {
            _appDbContext.Entry(materials).State = EntityState.Modified;
        }

        public async Task UpdateVariantStockAmountAsync(int variantId, int qty)
        {
            var row = await _appDbContext.VariantStocks.FindAsync(variantId);

            if (row != null)
            {
                row.Quantity = qty;
            }
            else
            {
                _appDbContext.VariantStocks.Add(new VariantStock { VariantId = variantId, Quantity=qty});
            }
        }

        public async Task SaveAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
