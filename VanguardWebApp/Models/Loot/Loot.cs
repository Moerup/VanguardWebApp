using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models
{
    public class Loot
    {
        public string ItemID { get; set; }

        public string Name { get; set; }

        public bool Quality { get; set; }

        public int GPValue { get; set; }

        public List<Priority> Priorities { get; set; }
    }
}
