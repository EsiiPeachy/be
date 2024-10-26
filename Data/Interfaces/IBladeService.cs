using BeybladeMatchMakerAPI.Objects.Entities;

namespace BeybladeMatchMakerAPI.Data.Interfaces
{
    public interface IBladeService
    {
        Task<List<BladeEntity>> GetAllBlade();
    }
}