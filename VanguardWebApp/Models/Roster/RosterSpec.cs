﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;

namespace VanguardWebApp.Models
{
    public class RosterSpec
    {
        public Spec Spec { get; set; }

        public List<Player> Players { get; set; }
    }
}