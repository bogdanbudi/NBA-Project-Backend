﻿using Newtonsoft.Json;

namespace Scoreboard.Domain.Entities.Games
{
    public class Meta
    {
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}
