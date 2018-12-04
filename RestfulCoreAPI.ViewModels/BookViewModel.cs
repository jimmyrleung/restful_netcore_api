using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace RestfulCoreAPI.ViewModels
{
    // If you don't want to use 'JsonProperty, there is another way to define the Model Data: DataContract
    // [DataContract]
    public class BookViewModel
    {
        [Key]
        [JsonProperty("id")]
        // [DataMember (Order = 1, Name = "id")] - Uncomment if using DataContract
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
