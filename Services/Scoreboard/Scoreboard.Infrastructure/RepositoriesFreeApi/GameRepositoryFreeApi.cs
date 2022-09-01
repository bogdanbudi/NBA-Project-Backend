using Newtonsoft.Json;
using Scoreboard.Application.Contracts.Persistence;
using Scoreboard.Domain.Entities;
using Scoreboard.Domain.Entities.Games;

namespace Scoreboard.Infrastructure.RepositoriesFreeApi
{
    public class GameRepositoryFreeApi : RepositoryBaseFreeApi<Game>, IGameRepository
    {
        private string[] Seasons = { "2017", "2018", "2019" };
        Random random = new Random();

        public GameRepositoryFreeApi()
        {
        }

        async Task<IEnumerable<Game>> IGameRepository.GetAllAsync()
        {
            string season = Seasons[random.Next(Seasons.Length)];
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://free-nba.p.rapidapi.com/games?per_page=10&seasons[]=" + season),
                Headers =
                {
                   { "X-RapidAPI-Key", "bc9c3295b0msh1a9333277702dc5p144ad2jsn1c83e596f081" },
                   { "X-RapidAPI-Host", "free-nba.p.rapidapi.com" },
                },
            };

            String body;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(body);
            return myDeserializedClass.Games.ToList();
        }
    }
}
