using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models.BiS
{
    public class BiSSpec
    {
        public string Name { get; set; }

        public List<Phase> Phases { get; set; }
    }
}
