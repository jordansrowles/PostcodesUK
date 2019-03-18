﻿using Newtonsoft.Json;

namespace PostcodesUK
{
    public class PostcodeResult
    {
        [JsonProperty("postcode")]
        public string Postcode { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("eastings")]
        public int Eastings { get; set; }
        [JsonProperty("northings")]
        public int Northings { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("nhs_ha")]
        public string NHSHA { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("european_electoral_region")]
        public string EUElectoralRegion { get; set; }
        [JsonProperty("primary_care_trust")]
        public string PrimaryCareTrust { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("lsoa")]
        public string LSOA { get; set; }
        [JsonProperty("msoa")]
        public string MSOA { get; set; }
        [JsonProperty("incode")]
        public string Incode { get; set; }
        [JsonProperty("outcode")]
        public string Outcode { get; set; }
        [JsonProperty("parliamentary_constituency")]
        public string Constituency { get; set; }
        [JsonProperty("admin_district")]
        public string AdminDistrict { get; set; }
        [JsonProperty("parish")]
        public string Parish { get; set; }
        [JsonProperty("admin_county")]
        public string AdminCounty { get; set; }
        [JsonProperty("admin_ward")]
        public string AdminWard { get; set; }
        [JsonProperty("ced")]
        public string CED { get; set; }
        [JsonProperty("ccg")]
        public string CCG { get; set; }
        [JsonProperty("nuts")]
        public string Nuts { get; set; }
        [JsonProperty("codes")]
        public Codes Codes { get; set; }
    }
}
