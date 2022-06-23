using Domain.Shots;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Shots
{
    internal class ShotConfiguration : IEntityTypeConfiguration<Shot>
    {
        public void Configure(EntityTypeBuilder<Shot> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Owner)
                .WithMany();
        }
    }
}
