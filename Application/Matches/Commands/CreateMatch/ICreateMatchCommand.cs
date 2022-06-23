namespace Application.Matches.Commands
{
    public interface ICreateMatchCommand
    {
        Task<string> ExecuteAsync(CreateMatchModel model);
    }
}
