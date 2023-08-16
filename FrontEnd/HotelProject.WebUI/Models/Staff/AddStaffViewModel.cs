
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelProject.WebUI.Models.Staff
{
    public class AddStaffViewModel
    {
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        [Required]
        public string Title { get; set; }
        
        [JsonPropertyName("socialMedia1")]
        [Required]
        public string SocialMedia1 { get; set; }
    }
}