using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;

namespace VanguardWebApp.Models.BiS
{
    public class Gear
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Slot Slot { get; set; }

        public string Name { get; set; }

        [BsonElement("Id")]
        public int ItemId { get; set; }
    }
}
