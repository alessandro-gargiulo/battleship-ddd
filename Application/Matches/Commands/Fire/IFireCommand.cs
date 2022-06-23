namespace Application.Matches.Commands
{
    public interface IFireCommand
    {
        Task<bool> ExecuteAsync(FireModel model);
    }
}
