using Domain.Common;
using Domain.Players;

namespace Domain.Shots
{
    public class Shot : IEntity
    {
        public int Id { get; set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public Player Owner { get; set; }

        public Shot(int x, int y, Player owner)
        {
            XCoord = x;
            YCoord = y;
            Owner = owner;
        }
    }
}
