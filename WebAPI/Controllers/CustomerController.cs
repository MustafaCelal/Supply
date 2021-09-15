using Business.ServiceInterfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer =_customerService.GetById(id);
            return Ok(customer);
            //return _customerRepository.Get(filter);
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Customer customer)
        {
            _customerService.Delete(customer);
            return Ok();
        }

        // it works well but its the same endpoint the above actions
        // it should be refactoring
        //[HttpDelete]
        //public IActionResult DeleteMultiple(IEnumerable<Customer> entities)
        //{
        //    _customerService.DeleteMultiple(entities);
        //    return Ok();
        //}
        [HttpPut]
        public IActionResult Update(Customer customer)
        {
            _customerService.Update(customer);
            return Ok();
        }

    }
}
