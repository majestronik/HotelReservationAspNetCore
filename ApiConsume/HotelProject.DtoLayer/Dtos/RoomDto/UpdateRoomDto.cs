
using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        [Required(ErrorMessage = "Please put room id")]
        public int Id { get; set; }
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
        [Required(ErrorMessage = "Please put description")]
        public string Description { get; set; }
    }
}