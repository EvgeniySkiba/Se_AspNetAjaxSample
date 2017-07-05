using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SE_Asp_Net_Ajax.Utils
{
    [JsonConverter(typeof(GenderEnumConverter))]
    public enum GenderEnum
    {
        Male,
        Female
    }
}