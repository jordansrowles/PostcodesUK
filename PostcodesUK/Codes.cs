using Newtonsoft.Json;

namespace PostcodesUK
{
    public class Codes
    {
        [JsonProperty("admin_district")]
        public string AdminDistrict { get; set; }
        [JsonProperty("admin_county")]
        public string AdminCounty { get; set; }
        [JsonProperty("admin_ward")]
        public string AdminWard { get; set; }
        [JsonProperty("parish")]
        public string Parish { get; set; }
        [JsonProperty("parliamentary_constituency")]
        public string Constituency { get; set; }
        [JsonProperty("ccg")]
        public string CCG { get; set; }
        [JsonProperty("ced")]
        public string CED { get; set; }
        [JsonProperty("nuts")]
        public string Nuts { get; set; }
    }
}
