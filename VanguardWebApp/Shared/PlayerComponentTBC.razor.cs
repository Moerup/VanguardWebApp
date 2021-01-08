using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;

namespace VanguardWebApp.Shared
{
    public partial class PlayerComponentTBC
    {
        [Parameter]
        public RosterSpecTBC RosterSpec  { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public string GetNationalityFlag(Player player)
        {
            var formattedSpec = $"/images/flags/{player.Nationality}.png";
            return formattedSpec;
        }

        public string GetSpecIcon()
        {
            var formattedSpec = $"/images/spec/{RosterSpec.Spec}.png";
            return formattedSpec;
        }

        public void NavigateToLogs(Player player)
        {
            var url = $@"https://classic.warcraftlogs.com/character/eu/gandling/{player.Name}";
            JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }
    }
}
