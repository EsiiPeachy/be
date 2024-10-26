using BeybladeMatchMakerAPI.Objects.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeybladeMatchMakerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet<TEntity> properties map to tables
        public DbSet<BladeEntity> bladeEntity { get; set; }
        public DbSet<PlayerEntity> playerEntity { get; set; }
        public DbSet<BitEntity> bitEntity { get; set; }

        // Optional: Fluent API configurations can go here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example of configuring a property or table (optional)
            modelBuilder.Entity<BladeEntity>()
                .HasKey(p => p.Id);  // Explicitly setting primary key (optional)
            modelBuilder.Entity<PlayerEntity>()
                .HasKey(p => p.Id);  
            modelBuilder.Entity<BitEntity>()
                .HasKey(p => p.Id); 
        }
    }
}
