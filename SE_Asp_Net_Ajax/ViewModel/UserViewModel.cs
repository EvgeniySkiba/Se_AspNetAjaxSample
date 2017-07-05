using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SE_Asp_Net_Ajax.Utils;

namespace SE_Asp_Net_Ajax.ViewModel
{
    public class UserViewModel
    {

        [JsonConverter(typeof(GenderEnumConverter))]
        public enum GenderEnum
        {
            Male,
            Female
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public GenderEnum Gender { get; set; }

        public string Email { get; set; }
    }
}