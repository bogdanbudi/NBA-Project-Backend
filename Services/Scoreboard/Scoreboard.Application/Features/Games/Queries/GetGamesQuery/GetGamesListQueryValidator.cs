using FluentValidation;

namespace Scoreboard.Application.Features.Games.Queries.GetGamesQuery
{
    public class GetGamesListQueryValidator: AbstractValidator<GetGamesListQuery>
    {
        public GetGamesListQueryValidator()
        {
         //   RuleFor(p => p).NotEmpty().WithMessage("{p} is required");
        }
    }
}
