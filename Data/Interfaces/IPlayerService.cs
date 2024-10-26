using BeybladeMatchMakerAPI.Objects.Entities;

namespace BeybladeMatchMakerAPI.Data.Interfaces
{
    public interface IPlayerService
    {
        Task<List<PlayerEntity>> GetAllPlayer();
    }
}