using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;

namespace VanguardWebApp.Models
{
    public class Group
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("Group")]
        public ClassGroup ClassGroup { get; set; }

        public int ListValue { get; set; }
    }
}
