using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;

namespace VanguardWebApp.Shared
{
    public partial class PlayerComponent
    {
        [Parameter]
        public RosterSpec RosterSpec  { get; set; }

        public string GetNationalityFlag(Player player)
        {
            var formattedSpec = $"/images/flags/{player.Nationality}.png";
            return formattedSpec;
        }
    }
}
