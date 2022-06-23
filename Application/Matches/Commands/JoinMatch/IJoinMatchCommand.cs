namespace Application.Matches.Commands
{
    public interface IJoinMatchCommand
    {
        Task<bool> ExecuteAsync(JoinMatchModel model);
    }
}
