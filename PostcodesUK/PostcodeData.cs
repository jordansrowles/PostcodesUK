using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PostcodesUK
{
    public static class PostcodeData
    {
        public static async Task<PostcodeResult> Get(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.postcodes.io/postcodes/{postcode}");
            return ApiClient.AttemptConvert<PostcodeResult>(json, "result");
        }

        public static async Task<IList<PostcodeResult>> Get(double longitude, double latitude)
        {
            var json = await ApiClient.QueryAsync($"https://api.postcodes.io/postcodes/lon/{longitude}/lat/{latitude}");
            return ApiClient.AttemptConvert<IList<PostcodeResult>>(json, "result");
        }

        public static async Task<PostcodeResult> Random()
        {
            var json = await ApiClient.QueryAsync("https://api.postcodes.io/random/postcodes");
            return ApiClient.AttemptConvert<PostcodeResult>(json, "result");
        }

        public static async Task<bool> IsValid(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.postcodes.io/postcodes/{postcode}/validate");
            var o = JObject.Parse(json);
            return (bool)o["result"];
        }

        public static async Task<List<string>> Autocomplete(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.postcodes.io/postcodes/{postcode}/autocomplete");
            return ApiClient.AttemptConvert<List<string>>(json, "result");
        }

        public static async Task<IList<PostcodeResult>> Nearest(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.postcodes.io/postcodes/{postcode}/nearest");
            return ApiClient.AttemptConvert<IList<PostcodeResult>>(json, "result");
        }

        public static async Task<IList<PostcodeResult>> Query(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.postcodes.io/postcodes?q={postcode}");
            return ApiClient.AttemptConvert<IList<PostcodeResult>>(json, "result");
        }
    }
}
