using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCoreAPI.Models
{
    public class Book
    {
        [Key]
        [Column("id")]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [Column("author")]
        [JsonProperty("author")]
        public string Author { get; set; }

        [Column("launchDate")]
        [JsonProperty("launchDate")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [Column("title")]
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
