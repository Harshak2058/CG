using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBAPIFirst.Repository;
using WEBAPIFirst.Model;
using WEBAPIFirst.Interface;

namespace WEBAPIFirst.Controller
{
    [ApiController]
    [Route("api/v{version:apiVersion}/customers")]
    //[ApiExplorerSettings(GroupName = "CustomerV1")]
    [ApiVersion("1.0")]
    public class CustomerV1Controller : ControllerBase
    {
        private readonly ICustomerV1Repository _customerV1Repository;
        public CustomerV1Controller(ICustomerV1Repository customerV1Repository)
        {
            _customerV1Repository = customerV1Repository;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _customerV1Repository.GetAll();
            return Ok(customers);
        }

        [HttpPost("AddToList")]
        public IActionResult AddToList([FromBody] CustomerV1 customer)
        {
            var customer1 = _customerV1Repository.AddCustomer(customer);
            return Ok(customer1);
        }

        [HttpPut("UpdateCustomer/{id}")]
        public IActionResult UpdateCustomer(int id,[FromBody] CustomerV1 customer)
        {
            bool result = _customerV1Repository.UpdateCustomer(id, customer);
            if(result)
            {
                return Ok("Updated succefully");
            }
            return BadRequest();
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            bool res = _customerV1Repository.DeleteCustomer(id);
            if(res)
            {
                return Ok("Deleted succesfully");
            }
            return NotFound();
        }
    }
}