namespace Application.Matches.Commands
{
    public class CreateMatchModel
    {
        public List<int> ShipLengthConfigurations { get; set; }
        public int FieldRows { get; set; }
        public int FieldColumns { get; set; }
        public int ExpectedPlayers { get; set; }

        public CreateMatchModel()
        {
            ShipLengthConfigurations = new List<int>();
        }
    }
}
