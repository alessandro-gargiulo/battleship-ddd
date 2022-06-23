using Domain.ShipSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.ShipSettings
{
    internal class ShipSettingConfiguration : IEntityTypeConfiguration<ShipSetting>
    {
        public void Configure(EntityTypeBuilder<ShipSetting> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
