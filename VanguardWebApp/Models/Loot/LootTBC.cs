using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models
{
    public class LootTBC
    {
        public string ItemID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public List<Group> Groups { get; set; }
    }
}
