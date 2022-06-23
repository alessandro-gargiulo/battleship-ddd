using Domain.Ships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Ships
{
    internal class ShipConfiguration : IEntityTypeConfiguration<Ship>
    {
        public void Configure(EntityTypeBuilder<Ship> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Positions)
                .WithOne();
            builder.HasOne(x => x.Player)
                .WithMany(x => x.Ships);
        }
    }
}
