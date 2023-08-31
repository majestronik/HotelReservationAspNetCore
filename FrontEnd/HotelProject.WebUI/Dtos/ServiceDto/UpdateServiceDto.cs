using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Service Icon Is Required")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Service Title Is Required")]
        [StringLength(100, ErrorMessage = "Title can be max 100 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Service Description Is Required")]
        [StringLength(250, ErrorMessage = "Description can be max 500 characters")]
        public string Description { get; set; }
    }
}