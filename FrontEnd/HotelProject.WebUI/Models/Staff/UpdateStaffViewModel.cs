using System.Text.Json.Serialization;

namespace HotelProject.WebUI.Models.Staff
{
    public class UpdateStaffViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("socialMedia1")]
        public string SocialMedia1 { get; set; }
        [JsonPropertyName("socialMedia2")]
        public string SocialMedia2 { get; set; }
        [JsonPropertyName("socialMedia3")]
        public string SocialMedia3 { get; set; }
    }
}