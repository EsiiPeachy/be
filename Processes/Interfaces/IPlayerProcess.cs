using BeybladeMatchMakerAPI.Objects.Models;

namespace BeybladeMatchMakerAPI.Processes.Interfaces
{
    public interface IPlayerProcess
    {
        Task<List<PlayerDto>> GetAllPlayer();
    }
}