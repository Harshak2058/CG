using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Repositories;

[ApiController]
[ApiVersion("2.0")]
[Route("api/customers")]
public class CustomerV2Controller : ControllerBase
{
    private readonly ICustomerV2Repository _repository;

    public CustomerV2Controller(ICustomerV2Repository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var customers = _repository.GetAll();
        return Ok(customers);
    }
}