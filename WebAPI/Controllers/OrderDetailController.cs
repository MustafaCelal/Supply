using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orderDetails = _orderDetailService.GetAll();
            return Ok(orderDetails);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var orderDetail = _orderDetailService.GetById(id);
            return Ok(orderDetail);
        }

        [HttpPost]
        public IActionResult Add(OrderDetail orderDetail)
        {
            _orderDetailService.Add(orderDetail);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(OrderDetail orderDetail)
        {
            _orderDetailService.Delete(orderDetail);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(OrderDetail orderDetail)
        {
            _orderDetailService.Update(orderDetail);
            return Ok();
        }

    }
}

