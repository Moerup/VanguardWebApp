using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VanguardWebApp.Models;
using VanguardWebApp.Models.BiS;
using VanguardWebApp.Models.Consumables;

namespace VanguardWebApp.Services
{
    public class APIAccessService
    {
        private HttpClient _client;
        private readonly string _endpoint = "https://vanguardapi.azurewebsites.net/api";

        public APIAccessService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Raid> GetRaidLootAsync(string raidName)
        {
            var requestUrl = @$"{_endpoint}/raid/{raidName}";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Raid>(result);
            return model;
        }

        public async Task<RaidTBC> GetRaidTbcLootAsync(string raidName)
        {
            var requestUrl = @$"{_endpoint}/raid/tbc/{raidName}";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<RaidTBC>(result);
            return model;
        }

        public async Task<Roster> GetRosterAsync()
        {
            var requestUrl = @$"{_endpoint}/Roster";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Roster>(result);
            return model;
        }

        public async Task<RosterTBC> GetRosterTBCAsync()
        {
            var requestUrl = @$"{_endpoint}/RosterTBC";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<RosterTBC>(result);
            return model;
        }

        public async Task<BiS> GetBiSLists()
        {
            var requestUrl = @$"{_endpoint}/bis";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<BiS>(result);
            return model;
        }

        public async Task<ConsumablesCollection> GetConsumablesCollectionAsync()
        {
            var requestUrl = @$"{_endpoint}/consumables";
            using var response = await _client.GetAsync(requestUrl);
            using var content = response.Content;
            string result = await content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<ConsumablesCollection>(result);
            return model;
        }
    }
}
