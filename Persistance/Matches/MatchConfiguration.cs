using Domain.Matches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Matches
{
    internal class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Players)
                .WithOne();
            builder.HasMany(x => x.Shots)
                .WithOne();
            builder.HasOne(x => x.Setting)
                .WithOne();
        }
    }
}
