using System;
using System.Collections.Generic;

using CustomerManagementSystem_webapi.Interfaces;
using CustomerManagementSystem_webapi.Models;
namespace CustomerManagementSystem_webapi.Controllers
{
     [ApiController]
    [Route("api/customers")]
    [ApiVersion("2.0")]

    public class CustomerV2Controller : ControllerBase
    {
        private readonly ICustomerV2Repository obj;
        public CustomerV2Controller(ICustomerV2Repository obj1)
        {
            obj=obj1;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers= obj.GetAll();
            return Ok(customers);
        }
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerV2 customer)
        {
            obj.Add(customer);
            return Ok("success");
        }

    }
}