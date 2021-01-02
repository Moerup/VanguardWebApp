using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;
using VanguardWebApp.Services;

namespace VanguardWebApp.Pages
{
    public partial class LootTBC
    {
        [Inject]
        public APIAccessService APIAccessService { get; set; }

        [Parameter]
        public string RaidName { get; set; }

        public bool dataIsLoaded = false;

        public RaidTBC RaidTBC { get; set; } = new RaidTBC();

        protected override async Task OnInitializedAsync()
        {
            RaidTBC = await APIAccessService.GetRaidTbcLootAsync(RaidName);
            dataIsLoaded = true;
            await base.OnInitializedAsync();
        }
    }
}
