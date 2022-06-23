using Domain.Common;
using Domain.Players;
using Domain.Settings;
using Domain.Ships;
using Domain.Shots;

namespace Domain.Matches
{
    public class Match : IEntity
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? LastPlayedOn { get; set; }
        public Setting Setting { get; set; }
        public List<Shot> Shots { get; set; }
        public List<Player> Players { get; set; }

        public Match()
        {
            Shots = new List<Shot>();
            Players = new List<Player>();
            Setting = new Setting();
        }

        public Match(Setting setting, DateTime createdOn) : this()
        {
            Setting = setting;
            CreatedOn = createdOn;
        }

        public bool IsTerminated(out Player? winner)
        {
            winner = null;

            var playersLost = Players.Where(p => p.Ships.TrueForAll(ship => ship.IsSinked())).ToArray();

            if((Players.Count - playersLost.Length) == 1)
            {
                // The match is terminated because only one the player is still alive
                //winner = Players.Select(p => p.Identifier).Except(playersLost.Select(l => l.Identifier)).FirstOrDefault();
                winner = Players.Except(playersLost).FirstOrDefault();
                return true;
            }

            return false;
        }
    }
}
