using BeybladeMatchMakerAPI.Objects.Entities;

namespace BeybladeMatchMakerAPI.Data.Interfaces
{
    public interface IBitService
    {
        Task<List<BitEntity>> GetAllBit();
    }
}