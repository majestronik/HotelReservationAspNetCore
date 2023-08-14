using HotelProject.DataAccessLayer.Abstact;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    public class StaffController : BaseApiController
    {
        private readonly IStaffDal _staffService;

        public StaffController(IStaffDal staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult ListStaff()
        {
            var values = _staffService.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }


    }
}