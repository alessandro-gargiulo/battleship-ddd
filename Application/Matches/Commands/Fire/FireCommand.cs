namespace Application.Matches.Commands
{
    public class FireCommand : IFireCommand
    {
        public Task<bool> ExecuteAsync(FireModel model)
        {
            // If any player is hitted by the shot return true.
            // A subsequent query can be used to retrieve who was hitted.
            throw new NotImplementedException();

        }
    }
}
