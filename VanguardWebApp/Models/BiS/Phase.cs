using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models.BiS
{
    public class Phase
    {
        public string Name { get; set; }

        public List<Gear> Gear { get; set; }
    }
}
