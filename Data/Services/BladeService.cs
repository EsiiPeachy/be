using BeybladeMatchMakerAPI.Data.Interfaces;
using BeybladeMatchMakerAPI.Objects.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeybladeMatchMakerAPI.Data.Services
{
    public class BladeService : IBladeService
    {
        private readonly AppDbContext context;
        public BladeService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<BladeEntity>> GetAllBlade()
        {
            var resp = await context.bladeEntity.ToListAsync();
            return resp;
        }
    }
}