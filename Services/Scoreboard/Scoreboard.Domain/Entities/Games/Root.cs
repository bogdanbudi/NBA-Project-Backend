using Newtonsoft.Json;

namespace Scoreboard.Domain.Entities.Games
{
    public class Root
    {

        [JsonProperty("data")]
        public List<Game> Games { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
