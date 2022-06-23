namespace Application.Matches.Commands
{
    public class JoinMatchModel
    {
        public string? MatchCode { get; set; }
        public Guid PlayerGuid { get; set; }
        public string? PlayerName { get; set; }
    }
}
