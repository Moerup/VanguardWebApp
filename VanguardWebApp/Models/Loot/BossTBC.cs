using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models
{
    public class BossTBC
    {
        [Required]
        public string Name { get; set; }

        public List<LootTBC> Loot { get; set; }
    }
}
