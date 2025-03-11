using System;
using System.Collections.Generic;

using CustomerManagementSystem_webapi.Interfaces;
using CustomerManagementSystem_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementSystem_webapi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/customers")]
    [ApiVersion("1.0")]

    public class CustomerV1Controller : ControllerBase
    {
        private readonly ICustomerV1Repository obj;
        public CustomerV1Controller(ICustomerV1Repository obj1)
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
        public IActionResult AddCustomer([FromBody] CustomerV1Controller customer)
        {
            obj.Add(customer);
            return Ok("success");
        }
        
    }
}