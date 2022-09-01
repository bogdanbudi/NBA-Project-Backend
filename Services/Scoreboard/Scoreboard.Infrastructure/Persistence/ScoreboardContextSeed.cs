using Microsoft.Extensions.Logging;
using Scoreboard.Domain.Entities;

namespace Scoreboard.Infrastructure.Persistence
{
    public class ScoreboardContextSeed
    {
        public static async Task SeedAsync(ScoreboardContext scoreboardContext, ILogger<ScoreboardContextSeed> logger)
        {
            if (!scoreboardContext.Games.Any() && !scoreboardContext.Teams.Any())
            {
                scoreboardContext.Teams.AddRange(GetPreconfiguredTeams());
                scoreboardContext.Games.AddRange(GetPreconfiguredGames());
                await scoreboardContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(ScoreboardContext).Name);
            }
        }


        private static IEnumerable<Game> GetPreconfiguredGames()
        {
            Team TeamOne = new Team() { Abbreviation = "BOS", City = "Boston", Conference = "East", Division = "Atlantic", FullName = "Boston Celtics", Name = "Celtics" };
            Team TeamTwo = new Team() { Abbreviation = "PHI", City = "Philadelphia", Conference = "East", Division = "Atlantic", FullName = "Philadelphia 76ers", Name = "76ers" };

            return new List<Game>
            {
                new Game() {Date = DateTime.Parse("2018-10-16T00:00:00.000Z"), HomeTeamScore = 105, VisitatorTeamScore = 87, Season = 2018, HomeTeam = TeamOne, VisitatorTeam = TeamTwo}
            };
        }

        private static IEnumerable<Team> GetPreconfiguredTeams()
        {

         Team TeamOne = new Team() { Abbreviation = "BOS", City = "Boston", Conference = "East", Division = "Atlantic", FullName = "Boston Celtics", Name = "Celtics" };
         Team TeamTwo = new Team() { Abbreviation = "PHI", City = "Philadelphia", Conference = "East", Division = "Atlantic", FullName = "Philadelphia 76ers", Name = "76ers" };
         return new List<Team>
            {
               TeamOne,
               TeamTwo
            };
        }
    }
}
