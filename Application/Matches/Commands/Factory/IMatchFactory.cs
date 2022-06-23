using Domain.Matches;
using Domain.Players;
using Domain.Settings;

namespace Application.Matches.Commands.Factory
{
    public interface IMatchFactory
    {
        Match CreateMatch(Setting setting);
    }
}
