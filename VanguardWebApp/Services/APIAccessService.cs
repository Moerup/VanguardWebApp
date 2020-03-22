using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VanguardWebApp.Models;

namespace VanguardWebApp.Services
{
    public class APIAccessService
    {
        private HttpClient _client;
        private readonly string _endpoint = "https://vanguardapi.azurewebsites.net/api/raid/";

        public APIAccessService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Raid> GetRaidLootAsync(string raidName)
        {
            var requestUrl = @$"{_endpoint}{raidName}";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Raid>(result);
            return model;
        }
    }
}
