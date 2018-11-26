using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace RestfulCoreAPI.ViewModels
{
    public class BookViewModel
    {
        [Key]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("launchDate")]
        public DateTime LaunchDate { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
