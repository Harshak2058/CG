using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBAPIFirst.Model;
using WEBAPIFirst.Interface;
using WEBAPIFirst.Repository;

namespace WEBAPIFirst.Controller
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/customers")]
    //[ApiExplorerSettings(GroupName = "CustomerV2")]
    public class CustomerV2Controller : ControllerBase
    {
        private readonly ICustomerV2Repository _customerV2Repository;
        public CustomerV2Controller(ICustomerV2Repository customerV2Repository)
        {
            _customerV2Repository = customerV2Repository;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            List<CustomerV2> customers = _customerV2Repository.GetAll();
            return Ok(customers);
        }

         [HttpPost("AddToList")]
        public IActionResult AddToList([FromBody] CustomerV2 customer)
        {
            var customer1 = _customerV2Repository.AddCustomer(customer);
            return Ok(customer1);
        }

        [HttpPut("UpdateCustomer/{id}")]
        public IActionResult UpdateCustomer(int id,[FromBody] CustomerV2 customer)
        {
            bool result = _customerV2Repository.UpdateCustomer(id, customer);
            if(result)
            {
                return Ok("Updated succefully");
            }
            return BadRequest();
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            bool res = _customerV2Repository.DeleteCustomer(id);
            if(res)
            {
                return Ok("Deleted succesfully");
            }
            return NotFound();
        }
    }
}