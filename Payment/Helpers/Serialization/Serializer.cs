using Newtonsoft.Json;
using Payment.Helpers.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Helpers.Serialization
{
    public class Serializer
    {
        public static string Serialize(object value, bool typeNameHandling = true)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { DateFormatString = SystemSettings.JsonDateTimePattern, ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

            if (typeNameHandling)
            {
                settings.TypeNameHandling = TypeNameHandling.Objects;
            }

            string json = JsonConvert.SerializeObject(value, settings);

            return json;
        }
    }
}
