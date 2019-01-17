using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tapioca.HATEOAS;

namespace RestfulCoreAPI.ViewModels
{
    public class PersonViewModel : ISupportsHyperMedia
    {
        [Key]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public char Gender { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
