using Newtonsoft.Json;
using Scoreboard.Domain.Common;

namespace Scoreboard.Domain.Entities
{
    public class Game: EntityBase
    {

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("home_team_score")]
        public int HomeTeamScore { get; set; }

        [JsonProperty("visitor_team_score")]
        public int VisitatorTeamScore { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("home_team")]
        public Team HomeTeam { get; set; }

        [JsonProperty("visitor_team")]
        public Team VisitatorTeam { get; set; }
    }
}
