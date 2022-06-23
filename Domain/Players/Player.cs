using Domain.Common;
using Domain.Ships;

namespace Domain.Players
{
    public class Player : IEntity, IEquatable<Player>
    {
        public int Id { get; set; }
        public Guid Identifier { get; set; }
        public string Name { get; set; }
        public DateTime LastAccessOn { get; set; }
        public bool IsCurrentTurn { get; set; }
        public List<Ship> Ships { get; set; }

        public Player() : this(string.Empty) { }

        public Player(string name)
        {
            Identifier = Guid.NewGuid();
            Name = name;
            Ships = new List<Ship>();
        }

        public bool Equals(Player? other)
        {
            if (other == null)
                return false;

            if (this.Id == other.Id)
                return true;
            else
                return false;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (obj is Player playerObj)
                return Equals(playerObj);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.Identifier.GetHashCode();
        }
    }
}
