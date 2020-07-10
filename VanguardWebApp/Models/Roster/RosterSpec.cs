using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;

namespace VanguardWebApp.Models
{
    public enum SpecForRoster
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
        Protection
    }

    public class RosterSpec
    {
        public SpecForRoster Spec { get; set; }

        public List<Player> Players { get; set; }
    }
}
