
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ResultServiceDto
    {
        [Required(ErrorMessage = "Service Icon Is Required")]
        [JsonPropertyName("serviceIcon")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Service Title Is Required")]
        [StringLength(100, ErrorMessage = "Title can be max 100 characters")]
        [JsonPropertyName("title")]

        public string Title { get; set; }
        [JsonPropertyName("description")]

        public string Description { get; set; }
    }
}