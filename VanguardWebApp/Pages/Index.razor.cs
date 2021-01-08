using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;
using VanguardWebApp.Services;

namespace VanguardWebApp.Pages
{
    public partial class Index
    {
        [Inject]
        public APIAccessService APIAccessService { get; set; }

        public bool dataIsLoaded = false;

        public RosterTBC RosterTBC { get; set; } = new RosterTBC();

        public string CalculateRosterNumber()
        {
            int rosterNumber = 0;
            foreach (var rosterSpec in RosterTBC.RosterSpecs)
            {
                rosterNumber += rosterSpec.Players.Count();
            }
            return rosterNumber.ToString();
        }

        protected override async Task OnInitializedAsync()
        {
            RosterTBC = await APIAccessService.GetRosterTBCAsync();
            dataIsLoaded = true;
            await base.OnInitializedAsync();
        }
    }
}
