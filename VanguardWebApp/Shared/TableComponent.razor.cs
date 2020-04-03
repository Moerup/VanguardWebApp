using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;

namespace VanguardWebApp.Shared
{
    public partial class TableComponent
    {
        [Parameter]
        public Boss Boss { get; set; }

        public string FormatSpec(Priority priority)
        {
            if (priority.PriorityValue == 0)
            {
                return $"/images/loot/{priority.Spec}_off.png";
            }

            var formattedSpec = $"/images/loot/{priority.Spec}.png";
            return formattedSpec;
        }

        public string CalculatePriorityClass(Priority priority)
        {
            if (priority == null)
            {
                return "norank";
            }

            switch (priority.PriorityValue)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";

            }

            return "norank";
        }

        public string ReturnBiSInfo(Loot loot)
        {
            if (loot.Quality)
            {
                return $"{loot.Name} *";
            }
            else
            {
                return loot.Name;
            }
        }
    }
}
