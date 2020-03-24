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
        private readonly Application _application = new Application();

        private readonly DiscordWebHookService _client;

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
        }
    }
}
