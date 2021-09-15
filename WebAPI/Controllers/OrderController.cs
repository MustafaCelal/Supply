using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _orderService.GetAll();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _orderService.GetById(id);
            return Ok(order);
        }

        [HttpPost]
        public IActionResult Add(Order order)
        {
            _orderService.Add(order);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Order order)
        {
            _orderService.Delete(order);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Order order)
        {
            _orderService.Update(order);
            return Ok();
        }
    }
}
