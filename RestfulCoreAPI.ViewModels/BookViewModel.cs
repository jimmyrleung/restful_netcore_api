using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tapioca.HATEOAS;

namespace RestfulCoreAPI.ViewModels
{
    // If you don't want to use 'JsonProperty, there is another way to define the Model Data: DataContract
    // [DataContract]
    public class BookViewModel: ISupportsHyperMedia
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

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
