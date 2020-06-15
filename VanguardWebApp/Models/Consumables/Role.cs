using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models.Consumables
{
    public class Role
    {
        [BsonElement("Role")]
        public string RoleName { get; set; }

        public List<Consumable> Consumables { get; set; }
    }
}
