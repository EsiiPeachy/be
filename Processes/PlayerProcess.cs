using BeybladeMatchMakerAPI.Data.Interfaces;
using BeybladeMatchMakerAPI.Data.Services;
using BeybladeMatchMakerAPI.Objects.Entities;
using BeybladeMatchMakerAPI.Objects.Models;
using BeybladeMatchMakerAPI.Processes.Interfaces;

namespace BeybladeMatchMakerAPI.Processes
{
    public class PlayerProcess : IPlayerProcess
    {
        private readonly IPlayerService playerService;
        public PlayerProcess(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        public async Task<List<PlayerDto>> GetAllPlayer()
        {
            var list = await playerService.GetAllPlayer();

            List<PlayerDto> resp = new List<PlayerDto>();
            foreach (var item in list)
            {
                resp.Add(ConvertToPlayerDto(item));
            }

            return resp;
        }

        private PlayerDto ConvertToPlayerDto(PlayerEntity item)
        {
            PlayerDto player = new PlayerDto()
            {
                Alias = item.Alias,
            };
            return player;
        }
    }
}
