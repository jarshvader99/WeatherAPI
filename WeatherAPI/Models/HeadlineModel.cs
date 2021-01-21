using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Source
    {
        [JsonPropertyName("id")]
        public string Id;

        [JsonPropertyName("name")]
        public string Name;
    }

    public class Article
    {
        [JsonPropertyName("source")]
        public Source Source;

        [JsonPropertyName("author")]
        public string Author;

        [JsonPropertyName("title")]
        public string Title;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("url")]
        public string Url;

        [JsonPropertyName("urlToImage")]
        public string UrlToImage;

        [JsonPropertyName("publishedAt")]
        public DateTime PublishedAt;

        [JsonPropertyName("content")]
        public string Content;
    }

    public class HeadlineModel
    {
        [JsonPropertyName("status")]
        public string Status;

        [JsonPropertyName("totalResults")]
        public int TotalResults;

        [JsonPropertyName("articles")]
        public List<Article> Articles;
    }


}
