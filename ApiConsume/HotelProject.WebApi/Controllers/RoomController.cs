using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    public class RoomController : BaseApiController
    {
        [HttpGet]
        public IActionResult ListRoom()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }


    }
}