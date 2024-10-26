using BeybladeMatchMakerAPI.Objects.Models;

namespace BeybladeMatchMakerAPI.Processes.Interfaces
{
    public interface IBladeProcess
    {
        Task<List<BladeDto>> GetAllBlade();
    }
}