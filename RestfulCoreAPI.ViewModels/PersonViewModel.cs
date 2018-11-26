using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace RestfulCoreAPI.ViewModels
{
    public class PersonViewModel
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
    }
}
