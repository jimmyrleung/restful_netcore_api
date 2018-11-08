using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCoreAPI.Models
{
    public class Person
    {
        [Column("id")]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [Column("firstName")]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Column("lastName")]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Column("gender")]
        [JsonProperty("gender")]
        public char Gender { get; set; }
    }
}
