using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models.Consumables;
using VanguardWebApp.Services;

namespace VanguardWebApp.Pages
{
    public partial class Consumables
    {
        [Inject]
        public APIAccessService APIAccessService { get; set; }

        public bool dataIsLoaded = false;

        public ConsumablesCollection ConsumablesCollection { get; set; } = new ConsumablesCollection();

        protected override async Task OnInitializedAsync()
        {
            ConsumablesCollection = await APIAccessService.GetConsumablesCollectionAsync();
            dataIsLoaded = true;
            await base.OnInitializedAsync();
        }
    }
}
