using Application.Interfaces;
using Domain.Matches;
using Domain.Players;
using Microsoft.EntityFrameworkCore;
using Persistance.Matches;
using Persistance.Players;
using Persistance.Positions;
using Persistance.Settings;
using Persistance.Ships;
using Persistance.ShipSettings;
using Persistance.Shots;

namespace Persistance
{
    internal class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<Match> Matches => Set<Match>();

        public Task SaveAsync()
        {
            return this.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MatchConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new ShipConfiguration());
            modelBuilder.ApplyConfiguration(new ShipSettingConfiguration());
            modelBuilder.ApplyConfiguration(new ShotConfiguration());
        }
    }
}
