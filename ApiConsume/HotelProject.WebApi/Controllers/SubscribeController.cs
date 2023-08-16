using HotelProject.DataAccessLayer.Abstact;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    public class SubscribeController : BaseApiController
    {
        private readonly ISubscribeDal _subscribeService;

        public SubscribeController(ISubscribeDal SubscribeService)
        {
            _subscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult ListSubscribe()
        {
            var values = _subscribeService.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var value = _subscribeService.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _subscribeService.Insert(Subscribe);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var val = _subscribeService.GetById(id);
            _subscribeService.Delete(val);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _subscribeService.Update(Subscribe);
            return Ok();
        }


    }
}