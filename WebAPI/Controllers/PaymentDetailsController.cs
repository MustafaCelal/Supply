using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        IPaymentDetailService _paymentDetailService;

        public PaymentDetailsController(IPaymentDetailService paymentDetailsService)
        {
            _paymentDetailService = paymentDetailsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var paymentList = _paymentDetailService.GetAll();
            return Ok(paymentList);
        }
        
        [HttpGet("GetAllWithSupplyDetail")]
        public IActionResult GetAllWithSupplyDetail()
        {
            var paymentList = _paymentDetailService.GetAllWithSupplyDetail();
            return Ok(paymentList);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var paymentDetailDto = _paymentDetailService.GetById(id);
            return Ok(paymentDetailDto);
        }
        
        [HttpGet("GetByIdWithSupplyDetail/{id}")]
        public IActionResult GetByIdWithSupplyDetail(int id)
        {
            var paymentDetailDto = _paymentDetailService.GetByIdWithSupplyDetail(id);
            return Ok(paymentDetailDto);
        }

        [HttpPost]
        public IActionResult Add(PaymentDetail paymentDetail)
        {
            _paymentDetailService.Add(paymentDetail);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(PaymentDetail paymentDetail)
        {
            _paymentDetailService.Delete(paymentDetail);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(PaymentDetail paymentDetail)
        {
            _paymentDetailService.Update(paymentDetail);
            return Ok();
        }

    }
}