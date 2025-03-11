using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Repositories;


[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/customers")]
public class CustomerV1Controller : ControllerBase
{
    private readonly ICustomerV1Repository _repository;

    public CustomerV1Controller(ICustomerV1Repository repository)
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