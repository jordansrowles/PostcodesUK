using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PostcodesUK
{
    public static class ApiClient
    {
        static WebClient NewClient()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            return client;
        }

        public static async Task<string> QueryAsync(string uri)
        {
            using (var client = NewClient())
            {
                return await client.DownloadStringTaskAsync(uri);
            }
        }

        public static T AttemptConvert<T>(string data, string part)
        {
            JObject response = JObject.Parse(data);
            return JsonConvert.DeserializeObject<T>(response[part].ToString());
        }
    }
}
