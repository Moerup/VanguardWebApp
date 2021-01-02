using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Enums;
using VanguardWebApp.Models;

namespace VanguardWebApp.Shared
{
    public partial class TableComponentTBC
    {
        [Parameter]
        public BossTBC Boss { get; set; }

        public string FormatSpec(Group group)
        {
            if (group.ListValue == 0)
            {
                return $"/images/loot/{group.ClassGroup}_off.png";
            }

            var formattedSpec = $"/images/loot/{group.ClassGroup}.png";
            return formattedSpec;
        }

        public string GetIconPath(string ItemId)
        {
            return $"/images/icons_tbc/{ItemId}.png";
        }

        public string CalculatePrice(int price)
        {
            if (price == null)
            {
                return "norank";
            }

            switch (price)
            {
                case 0:
                    return "priceZero";
                case 1:
                    return "priceOne";
                case 2:
                    return "priceTwo";

            }
            return "norank";
        }

        public string ReturnDisplayName(ClassGroup classGroup)
        {
            switch (classGroup)
            {
                case ClassGroup.Tank:
                    return "Tanks";
                case ClassGroup.Phys:
                    return "Physical DPS";
                case ClassGroup.Cast:
                    return "Caster DPS";
                case ClassGroup.Heal:
                    return "Healers";
                default:
                    return classGroup.ToString();
            }
        }
    }
}
