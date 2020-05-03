using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models.BiS;
using VanguardWebApp.Services;

namespace VanguardWebApp.Pages
{
    public partial class SpecGuides
    {
        [Inject]
        public APIAccessService APIAccessService { get; set; }

        public bool dataIsLoaded = false;

        public BiS BiS { get; set; } = new BiS();

        public string GetIconPath(string specName)
        {
            return $"/images/spec/{specName}.png";
        }

        protected override async Task OnInitializedAsync()
        {
            BiS = await APIAccessService.GetBiSLists();
            dataIsLoaded = true;
            await base.OnInitializedAsync();
        }
    }
}
