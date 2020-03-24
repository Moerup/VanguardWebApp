using Discord;
using Discord.Webhook;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VanguardWebApp.Models;

public class DiscordWebHookService : IDisposable
{
    private readonly DiscordWebhookClient _client;
    private readonly string _webHook = "https://discordapp.com/api/webhooks/692091179189141575/KFmdNtnxoHruB4bRNNmqM7jJ-5xCPk4cdxjJCC7fpXZufBqN6p0FmgTKJIIgQGvJKNDT";

    public DiscordWebHookService()
    {
        _client = new DiscordWebhookClient(_webHook);
    }

    public void SendMessage(Application application)
    {
        var embeds = new List<Embed>();
        var builder = new EmbedBuilder();

        builder.AddField("Character name:", application.CharacterName);
        builder.AddField("Class:", application.Class);
        builder.AddField("Spec:", application.Spec);
        builder.AddField("Message:", application.Message);

        embeds.Add(builder.Build());

        _client.SendMessageAsync(embeds: embeds);
        Dispose();
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}