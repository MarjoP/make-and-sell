using MaterialStorage.Models;

namespace MaterialStorage.Data.Repo
{
    public class RawMaterialRepository : IRawMaterialRepository
    {
        public void AddNewRawMaterial(RawMaterial rawMaterial)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RawMaterial>> GetAllRawMaterialsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RawMaterial> GetRawMaterialAsync(int rawMaterialId)
        {
            throw new NotImplementedException();
        }

        public int GetRawMaterialStockAmount(int rawMaterialId)
        {
            throw new NotImplementedException();
        }

        public void UpdateRawMaterial(RawMaterial rawMaterial)
        {
            throw new NotImplementedException();
        }

        public void UpdateRawMaterialStockAmount(int rawMaterialId, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
