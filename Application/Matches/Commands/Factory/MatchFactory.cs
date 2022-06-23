using Common.Codes;
using Common.Dates;
using Domain.Matches;
using Domain.Settings;

namespace Application.Matches.Commands.Factory
{
    internal class MatchFactory : IMatchFactory
    {
        private readonly IDateService _dateService;
        private readonly ICodeService _codeService;

        public MatchFactory(IDateService dateService, ICodeService codeService)
        {
            _dateService = dateService;
            _codeService = codeService;
        }

        public Match CreateMatch(Setting setting)
        {
            DateTime createdOn = _dateService.GetDate();

            Match match = new(setting, createdOn)
            {
                Code = _codeService.GenerateCode(8) // TODO: Make a constant
            };

            return match;
        }
    }
}
