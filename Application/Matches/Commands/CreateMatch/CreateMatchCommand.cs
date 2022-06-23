using Application.Interfaces;
using Application.Matches.Commands.Factory;
using Domain.Matches;
using Domain.Players;
using Domain.Settings;
using Domain.Ships;
using Domain.ShipSettings;

namespace Application.Matches.Commands
{
    public class CreateMatchCommand : ICreateMatchCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMatchFactory _matchFactory;

        public CreateMatchCommand(IDatabaseService databaseService, IMatchFactory matchFactory)
        {
            _databaseService = databaseService;
            _matchFactory = matchFactory;
        }

        public async Task<string> ExecuteAsync(CreateMatchModel model)
        {
            List<ShipSetting> shipSettings = model.ShipLengthConfigurations.Select(sc => new ShipSetting(sc)).ToList();

            Setting setting = new(model.FieldRows, model.FieldColumns, model.ExpectedPlayers, shipSettings);

            Match newMatch = _matchFactory.CreateMatch(setting);

            await _databaseService.Matches.AddAsync(newMatch);

            await _databaseService.SaveAsync();

            return newMatch?.Code ?? string.Empty;
        }
    }
}
