using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderPayDetailsController : ControllerBase
    {
        IOrderPayDetailService _orderPayDetailService;

        public OrderPayDetailsController(IOrderPayDetailService orderPayDetailsService)
        {
            _orderPayDetailService = orderPayDetailsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderPayDetails = _orderPayDetailService.GetAll();
            return Ok(orderPayDetails);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var orderPayDetail = _orderPayDetailService.GetById(id);
            return Ok(orderPayDetail);
        }

        [HttpPost]
        public IActionResult Add(OrderPayDetail orderPayDetail)
        {
            _orderPayDetailService.Add(orderPayDetail);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(OrderPayDetail orderPayDetail)
        {
            _orderPayDetailService.Delete(orderPayDetail);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(OrderPayDetail orderPayDetail)
        {
            _orderPayDetailService.Update(orderPayDetail);
            return Ok();
        }

    }
}