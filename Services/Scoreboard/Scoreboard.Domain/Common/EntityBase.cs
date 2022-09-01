using Newtonsoft.Json;

namespace Scoreboard.Domain.Common
{
    public abstract class EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; protected set; }

       // I commented the following lines because the api in the request does not provide this information, but normally I would have wanted it for any entity

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

    }
}
