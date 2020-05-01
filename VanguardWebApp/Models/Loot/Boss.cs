using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models
{
    public class Boss
    {
        [Required]
        public string Name { get; set; }

        public List<Loot> Loot { get; set; }
    }
}
