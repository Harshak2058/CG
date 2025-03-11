using Microsoft.AspNetCore.Mvc; // For Controller, ActionResult, HTTP methods
using CMS_webapi.Repositories;   // For using ProductRepository (dependency injection)
using CMS_webapi.Models;        // For using your Product model
using System.Linq;

namespace CMS_webapi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/customers")]
    [ApiController]
    public class CustomerV1Controller : ControllerBase
    {
        private readonly ICustomerV1Repository _repository;

        public CustomerV1Controller(ICustomerV1Repository repository)
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
        public IActionResult AddCustomer([FromBody] CustomerV1 customer)
        {
            _repository.AddCustomer(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerV1 customer)
        {
            if (id != customer.Id)
            {
                return BadRequest("Customer ID mismatch");
            }

            var existingCustomer = _repository.GetById(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            _repository.UpdateCustomer(customer);
            return NoContent();
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

