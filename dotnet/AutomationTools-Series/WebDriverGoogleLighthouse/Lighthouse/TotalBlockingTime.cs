using Newtonsoft.Json;
namespace WebDriverGoogleLighthouse
{
    public class TotalBlockingTime
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("scoreDisplayMode")]
        public string ScoreDisplayMode { get; set; }

        [JsonProperty("numericValue")]
        public int NumericValue { get; set; }

        [JsonProperty("numericUnit")]
        public string NumericUnit { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}