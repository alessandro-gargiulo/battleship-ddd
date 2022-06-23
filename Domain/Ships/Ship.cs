using Domain.Common;
using Domain.Players;
using Domain.Positions;

namespace Domain.Ships
{
    public class Ship : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Player Player { get; set; }
        public List<Position> Positions { get; set; }

        public Ship()
        {
            Player = new Player();
            Positions = new List<Position>();
        }

        public Ship(string name) : this()
        {
            Name = name;
        }

        public Ship(Player player, string name, Tuple<int, int>[] coordinates) : this(name)
        {
            Player = player;

            foreach(var coord in coordinates)
            {
                Positions.Add(new Position(coord.Item1, coord.Item2));
            }
        }

        public bool IsSinked()
        {
            return Positions.All(pos => pos.IsHit);
        }
    }
}
