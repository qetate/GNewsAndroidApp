using System.Text.Json.Serialization;

namespace GNewsAndroidApp.Models
{
    public class Article
    {
        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("content")]
        public string content { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        [JsonPropertyName("publishedAt")]
        public DateTime publishedAt { get; set; }

        [JsonPropertyName("source")]
        public Source source { get; set; }
    }

    public class GNews
    {
        [JsonPropertyName("totalArticles")]
        public int totalArticles { get; set; }

        [JsonPropertyName("articles")]
        public List<Article> articles { get; set; }
    }

    public class Source
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}