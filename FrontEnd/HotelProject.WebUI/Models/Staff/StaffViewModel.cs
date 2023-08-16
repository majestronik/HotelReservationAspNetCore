using System.Text.Json.Serialization;

namespace HotelProject.WebUI.Models.Staff
{
    public class StaffViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]

        public string Name { get; set; }
        [JsonPropertyName("title")]

        public string Title { get; set; }
    }
}