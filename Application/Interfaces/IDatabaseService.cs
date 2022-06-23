using Domain.Matches;
using Domain.Players;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Match> Matches { get;}
        Task SaveAsync();
    }
}
