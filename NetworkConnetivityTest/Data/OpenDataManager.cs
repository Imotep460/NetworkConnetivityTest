using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetworkConnetivityTest.Data
{
    class OpenDataManager
    {
        private string URL = "https://sg.media-imdb.com/suggests/l/lord.json";

        public OpenDataManager()
        {

        }

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            // Login Information and confirmation.
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<OpenDataItem> GetAll()
        {
            HttpClient client = GetClient();

            string stringResult = await client.GetStringAsync(URL);
            stringResult = stringResult.Replace("imdb$lord(", "");

            // Remove the last character in the string.
            stringResult = stringResult.Remove(stringResult.Length - 1);

            return JsonConvert.DeserializeObject<OpenDataItem>(stringResult);
        }
    }
}
