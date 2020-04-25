using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models
{
    public enum Spec
    {
        Holy,
        Discipline,
        Shadow,
        Bear,
        Cat,
        Restoration,
        Marksmanship,
        Frost,
        Fire,
        Destruction,
        Combat,
        Fury,
        Protection,
        Mitigation
    }

    public class Priority
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Spec Spec { get; set; }

        public int PriorityValue { get; set; }
    }
}
