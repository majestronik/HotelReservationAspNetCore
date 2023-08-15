using HotelProject.DataAccessLayer;
using HotelProject.DataAccessLayer.Abstact;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    public class TestimonialController : BaseApiController
    {
        private readonly ITestimonialDal _testimonialService;

        public TestimonialController(ITestimonialDal TestimonialService)
        {
            _testimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult ListTestimonial()
        {
            var values = _testimonialService.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial Testimonial)
        {
            _testimonialService.Insert(Testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var val = _testimonialService.GetById(id);
            _testimonialService.Delete(val);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _testimonialService.Update(Testimonial);
            return Ok();
        }


    }
}