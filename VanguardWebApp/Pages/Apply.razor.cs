using Discord.WebSocket;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanguardWebApp.Models;

namespace VanguardWebApp.Pages
{
    public partial class Apply
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }

        private readonly Application _application = new Application();

        private readonly DiscordWebHookService _client;

        private string StatusMessage;

        private string StatusClass;

        public Apply()
        {
            _client = new DiscordWebHookService();
        }

        private void SendApplication()
        {
            using (_client)
            {
                _client.SendMessage(_application);
            }
            StatusClass = "alert-success";
            StatusMessage = "Your application was sent, we will contact you shortly!";
        }
    }
}
