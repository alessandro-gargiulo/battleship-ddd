using Domain.Common;
using Domain.ShipSettings;

namespace Domain.Settings
{
    public class Setting : IEntity
    {
        public int Id { get; set; }
        public int NRows { get; set; } // Nummber of rows in the grid
        public int NColumns { get; set; } // Nummber of columns in the grid
        public int NPlayers { get; set; } // Number of players who attend to join
        public List<ShipSetting> ShipSettings { get; set; }
        public int NumberOfShips { get { return ShipSettings.Count; } }

        public Setting()
        {
            ShipSettings = new List<ShipSetting>();
        }

        public Setting(int nRows, int nColumns, int nPlayers, List<ShipSetting> shipSettings) : this()
        {
            NRows = nRows;
            NColumns = nColumns;
            NPlayers = nPlayers;
        }
    }
}
