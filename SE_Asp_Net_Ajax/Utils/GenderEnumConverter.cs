using Newtonsoft.Json;
using SE_Asp_Net_Ajax.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE_Asp_Net_Ajax.Utils
{
    public class GenderEnumConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            if (string.Compare(value, "M", true) == 0)
            {
                return GenderEnum.Male;
            }
            if (string.Compare(value, "F", true) == 0)
            {
                return GenderEnum.Female;
            }
            return GenderEnum.Male;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var obj = (GenderEnum)value;

            // Write associative array field name
            writer.WriteValue(value.ToString().Substring(0, 1));
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }
}