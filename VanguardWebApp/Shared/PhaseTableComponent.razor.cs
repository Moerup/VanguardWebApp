using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models.BiS;

namespace VanguardWebApp.Shared
{
    public partial class PhaseTableComponent
    {
        [Parameter]
        public List<Phase> Phases { get; set; }

        public string GetIconPath(int itemId)
        {
            return $"/images/icons/{itemId}.png";
        }
    }
}