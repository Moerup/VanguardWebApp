using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;
using VanguardWebApp.Services;

namespace VanguardWebApp.Pages
{
    public partial class RosterPage
    {
        [Inject]
        public APIAccessService APIAccessService { get; set; }

        public bool dataIsLoaded = false;

        public Roster Roster { get; set; } = new Roster();

        protected override async Task OnInitializedAsync()
        {
            Roster = await APIAccessService.GetRosterAsync();
            dataIsLoaded = true;
            await base.OnInitializedAsync();
        }
    }
}
