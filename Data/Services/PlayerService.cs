using BeybladeMatchMakerAPI.Data.Interfaces;
using BeybladeMatchMakerAPI.Objects.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeybladeMatchMakerAPI.Data.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly AppDbContext context;

        public PlayerService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<PlayerEntity>> GetAllPlayer()
        {
            var resp = await context.playerEntity.ToListAsync();
            return resp;

        }
    }
}