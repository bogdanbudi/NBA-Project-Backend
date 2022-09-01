
namespace Scoreboard.Application.Features.Games.Queries.GetGamesQuery
{
    public class GamesVm
    {
        public string Date { get; set; }

        public string HomeTeamName { get; set; }

        public int HomeTeamScore { get; set; }

        public string VisitatorTeamName { get; set; }

        public int VisitatorTeamScore { get; set; }

        public int Season { get; set; }
    }
}
