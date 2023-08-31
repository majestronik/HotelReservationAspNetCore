
using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please put room number")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please put room price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please put room title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please put bed count")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please put bath count")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}