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
            var value = _staffService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var val = _staffService.GetById(id);
            _staffService.Delete(val);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.Update(staff);
            return Ok();
        }


    }
}