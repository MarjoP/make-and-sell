using MaterialStorage.DTOs;
using MaterialStorage.Models;

namespace MaterialStorage.Data.Repo
{
    public interface IProductRepository
    {
        Task AddNewProductAsync(Product product);
        void UpdateProduct(Product product);
        Task<Product> GetProductAsync(int productId);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task AddNewVariantAsync(Variant variant);    
        void UpdateVariant(Variant variant);    
        Task<Variant> GetVariantAsync(int variantId);
        Task<IEnumerable<Variant>> GetAllVariantsAsync();
        Task AddVariantMaterialsAsync(VariantBomDTO materials);
        void UpdateVariantMaterials(VariantBomDTO materials);   
        Task<int> GetVariantStockAmountAsync(int variantId);
        Task UpdateVariantStockAmountAsync(int variantId, int amount);
        Task SaveAsync();

    }
}
