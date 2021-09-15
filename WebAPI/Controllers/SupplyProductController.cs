using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplyProductController : ControllerBase
    {
        ISupplyProductService _supplyProductService;

        public SupplyProductController(ISupplyProductService supplyProductService)
        {
            _supplyProductService = supplyProductService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var supplyProducts = _supplyProductService.GetAll();
            return Ok(supplyProducts);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var supplyProduct = _supplyProductService.GetById(id);
            return Ok(supplyProduct);
        }

        [HttpPost]
        public IActionResult Add(SupplyProduct supplyProduct)
        {
            _supplyProductService.Add(supplyProduct);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(SupplyProduct supplyProduct)
        {
            _supplyProductService.Delete(supplyProduct);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(SupplyProduct supplyProduct)
        {
            _supplyProductService.Update(supplyProduct);
            return Ok();
        }

    }
}

