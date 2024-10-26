using BeybladeMatchMakerAPI.Data.Interfaces;
using BeybladeMatchMakerAPI.Data.Services;
using BeybladeMatchMakerAPI.Objects.Entities;
using BeybladeMatchMakerAPI.Objects.Models;
using BeybladeMatchMakerAPI.Processes.Interfaces;

namespace BeybladeMatchMakerAPI.Processes
{
    public class BladeProcess : IBladeProcess
    {
        private readonly IBladeService bladeService;
        public BladeProcess(IBladeService bladeService)
        {
            this.bladeService = bladeService;
        }

        public async Task<List<BladeDto>> GetAllBlade()
        {
            var list = await bladeService.GetAllBlade();

            List<BladeDto> resp = new List<BladeDto>();
            foreach (var item in list)
            {
                resp.Add(ConvertToBladeDto(item));
            }

            return resp;
        }

        private BladeDto ConvertToBladeDto(BladeEntity item)
        {
            BladeDto blade = new BladeDto()
            {
                Name = item.Name,
                Variant = item.Variant,
            };
            return blade;
        }
    }
}
