using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;
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

        public string GetIconPath(string Id)
        {
            return $"/images/icons/{Id}.png";
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

        public string ReturnDisplayName(Spec spec)
        {
            switch (spec)
            {
                case Spec.CombatSword:
                    return "Combat Sword";
                case Spec.CombatDagger:
                    return "Combat Dagger";
                case Spec.FuryHuman:
                    return "Fury Human";
                case Spec.FuryNonHuman:
                    return "Fury Non-human";
                case Spec.Offtank:
                    return "Off Tank";
                default:
                    return spec.ToString();
            }
        }
    }
}
