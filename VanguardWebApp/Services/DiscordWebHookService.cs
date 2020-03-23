using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class DiscordWebHookService : IDisposable
{
    private readonly WebClient _client;
    public string WebHook { get; set; }
    public string UserName { get; set; }
    public string ProfilePicture { get; set; }

    public DiscordWebHookService()
    {
        _client = new WebClient();
    }

    public void SendMessage(string message)
    {
        var discordValues = new NameValueCollection();
        discordValues.Add("username", UserName);
        discordValues.Add("content", message);

        _client.UploadValues(WebHook, discordValues);
        Dispose();
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}