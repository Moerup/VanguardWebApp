using Discord.WebSocket;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Pages
{
    public partial class Apply
    {
        private readonly DiscordWebHookService _client;

        public Apply()
        {
            _client = new DiscordWebHookService();
        }

        public void SendApplication(string message)
        {
            using (_client)
            {
                _client.UserName = "ApplicationBot";
                _client.WebHook = "https://discordapp.com/api/webhooks/691748687608807516/QtrfyclUbq9Lojew6QZWe9IrTaluu3LYUk8K9fy3HPFt_eDoSUf7CffeJZnnUXUiTdIT";
                _client.SendMessage(message);
            }
        }
    }
}
