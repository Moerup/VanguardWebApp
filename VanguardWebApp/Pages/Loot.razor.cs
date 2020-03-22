using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;
using VanguardWebApp.Services;

namespace VanguardWebApp.Pages
{
    public partial class Loot
    {
        [Inject]
        public APIAccessService APIAccessService { get; set; }

        [Parameter]
        public string RaidName { get; set; }

        public bool dataIsLoaded = false;

        public Raid Raid { get; set; } = new Raid();

        public string FormatSpec(Priority priority)
        {
            var formattedSpec = $"/images/loot/{priority.Spec}.png";
            return formattedSpec;
        }

        protected override async Task OnInitializedAsync()
        {
            Raid = await APIAccessService.GetRaidLootAsync(RaidName);
            dataIsLoaded = true;
            await base.OnInitializedAsync();
        }
    }
}
