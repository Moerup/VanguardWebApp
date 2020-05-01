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

        private string StatusMessage;

        private string StatusClass;

        private void SendApplication()
        {
            var client = new DiscordWebHookService();
            using (client)
            {
                client.SendMessage(_application);
            }
            StatusClass = "alert-success";
            StatusMessage = "Your application was sent, please contact us ingame to make sure we received your application!";
        }
    }
}
