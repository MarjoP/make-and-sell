using MaterialStorage.Models;

namespace MaterialStorage.Data.Repo
{
    public interface IRawMaterialRepository
    {
        Task<RawMaterial> GetRawMaterialAsync(int rawMaterialId);
        Task<IEnumerable<RawMaterial>> GetAllRawMaterialsAsync();
        void AddNewRawMaterial(RawMaterial rawMaterial);
        void UpdateRawMaterial(RawMaterial rawMaterial);
        void UpdateRawMaterialStockAmount(int rawMaterialId, int amount);
        int GetRawMaterialStockAmount(int rawMaterialId);
    }
}
