using MediatR;

namespace Scoreboard.Application.Features.Games.Queries.GetGamesQuery
{
    public class GetGamesListQuery: IRequest<List<GamesVm>>
    {
        public GetGamesListQuery()
        {

        }
    }
}
