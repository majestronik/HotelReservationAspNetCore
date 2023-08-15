using HotelProject.DataAccessLayer.Abstact;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    public class RoomController : BaseApiController
    {
        private readonly IRoomDal _roomService;

        public RoomController(IRoomDal RoomRoom)
        {
            _roomService = RoomRoom;
        }

        [HttpGet]
        public IActionResult ListRoom()
        {
            var values = _roomService.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _roomService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _roomService.Insert(Room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var val = _roomService.GetById(id);
            _roomService.Delete(val);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _roomService.Update(Room);
            return Ok();
        }


    }
}