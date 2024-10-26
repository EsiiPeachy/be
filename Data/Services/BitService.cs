using BeybladeMatchMakerAPI.Data.Interfaces;
using BeybladeMatchMakerAPI.Objects.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeybladeMatchMakerAPI.Data.Services
{
    public class BitService : IBitService
    {
        private readonly AppDbContext context;
        public BitService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<BitEntity>> GetAllBit()
        {
            var resp = await context.bitEntity.ToListAsync();
            return resp;
        }
    }
}