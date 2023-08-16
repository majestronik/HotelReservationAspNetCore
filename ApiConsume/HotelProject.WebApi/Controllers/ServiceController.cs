using HotelProject.DataAccessLayer.Abstact;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    public class ServiceController : BaseApiController
    {
        private readonly IServiceDal _serviceService;

        public ServiceController(IServiceDal ServiceService)
        {
            _serviceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ListService()
        {
            var values = _serviceService.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _serviceService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _serviceService.Insert(Service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var val = _serviceService.GetById(id);
            _serviceService.Delete(val);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _serviceService.Update(Service);
            return Ok();
        }


    }
}