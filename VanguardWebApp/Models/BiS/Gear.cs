using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;

namespace VanguardWebApp.Models.BiS
{
    public class Gear
    {
        public string Slot { get; set; }

        public string Name { get; set; }

        [BsonElement("Id")]
        public int ItemId { get; set; }
    }
}
