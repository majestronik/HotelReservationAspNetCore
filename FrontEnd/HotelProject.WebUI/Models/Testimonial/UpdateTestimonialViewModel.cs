using System.Text.Json.Serialization;

namespace HotelProject.WebUI.Models.Testimonial
{
    public class UpdateTestimonialViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}