using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplyDetailController : ControllerBase
    {
        private readonly ISupplyDetailService _supplyDetailService;

        public SupplyDetailController(ISupplyDetailService supplyDetailService)
        {
            _supplyDetailService = supplyDetailService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var supplyDetails = _supplyDetailService.GetAll();
            return Ok(supplyDetails);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var supplyDetail = _supplyDetailService.GetById(id);
            return Ok(supplyDetail);
        }

        [HttpPost]
        public IActionResult Add(SupplyDetail supplyDetail)
        {
            _supplyDetailService.Add(supplyDetail);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(SupplyDetail supplyDetail)
        {
            _supplyDetailService.Delete(supplyDetail);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(SupplyDetail supplyDetail)
        {
            _supplyDetailService.Update(supplyDetail);
            return Ok();
        }

    }
}

