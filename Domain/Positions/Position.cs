using Domain.Common;

namespace Domain.Positions
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public bool IsHit { get; set; }

        public Position()
        {
            IsHit = false;
        }

        public Position(int x, int y) : this()
        {
            XCoord = x;
            YCoord = y;
        }
    }
}
