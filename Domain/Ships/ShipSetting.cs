using Domain.Common;

namespace Domain.ShipSettings
{
    public class ShipSetting : IEntity
    {
        public int Id { get; set; }
        public int Length { get; set; }

        public ShipSetting() { }

        public ShipSetting(int length)
        {
            Length = length;
        }
    }
}
