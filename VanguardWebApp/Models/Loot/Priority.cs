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
    public class Priority
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Spec Spec { get; set; }

        public int PriorityValue { get; set; }
    }
}
