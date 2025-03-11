using Microsoft.AspNetCore.Mvc; // For Controller, ActionResult, HTTP methods
using CMS_webapi.Repositories;   // For using ProductRepository (dependency injection)
using CMS_webapi.Models;        // For using your Product model

namespace CMS_webapi.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/customers")]
    [ApiController]
    public class CustomerV2Controller : ControllerBase
    {
        private readonly ICustomerV2Repository _repository;

        public CustomerV2Controller(ICustomerV2Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _repository.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _repository.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerV2 customer)
        {
            _repository.AddCustomer(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerV2 updatedCustomer)
        {
            if (id != updatedCustomer.Id)
            {
                return BadRequest();
            }

            var success = _repository.UpdateCustomer(updatedCustomer);
            if (success)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCustomer(int id)
        {
            var success = _repository.RemoveCustomer(id);
            if (success)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}