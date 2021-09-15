using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplyController : ControllerBase
    {
        ISupplyService _supplyService;

        public SupplyController(ISupplyService supplyService)
        {
            _supplyService = supplyService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var supplies = _supplyService.GetAll();
            return Ok(supplies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var supply = _supplyService.GetById(id);
            return Ok(supply);
        }

        [HttpPost]
        public IActionResult Add(Supply supply)
        {
            _supplyService.Add(supply);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Supply supply)
        {
            _supplyService.Delete(supply);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Supply supply)
        {
            _supplyService.Update(supply);
            return Ok();
        }
    }
}
