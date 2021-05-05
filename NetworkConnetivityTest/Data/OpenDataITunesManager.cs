using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetworkConnetivityTest.Data
{
    class OpenDataITunesManager
    {
        private string URL = "https://itunes.apple.com/us/rss/topmovies/limit=25/json";

        public OpenDataITunesManager()
        {

        }

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            // Login information and confirmation.

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<OpenDataITunes> GetAll()
        {
            HttpClient client = GetClient();

            string stringResult = await client.GetStringAsync(URL);

            return JsonConvert.DeserializeObject<OpenDataITunes>(stringResult);
        }
    }
}
