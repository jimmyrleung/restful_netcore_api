using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.ViewModels
{
    public class UserViewModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
