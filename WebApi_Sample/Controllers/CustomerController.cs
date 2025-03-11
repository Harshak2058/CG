using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v{version:apiVersion}/customers")]
public class CustomersController : ControllerBase
{
    [HttpGet]
    [MapToApiVersion("1.0")]
    public IActionResult GetV1()
    {
        return Ok(new[]
        {
            new { id = 1, name = "Harsha", address = "vizag" },
            new { id = 2, name = "Avi", address = "Hyderabad" },
            new { id = 3, name = "Varsha", address = "Visakhapatnam" },
            new { id = 4, name = "Ronnie", address = "Bangalore" },
            new { id = 5, name = "Vardhan", address = "Mumbai" }
        });
    }

    [HttpGet]
    [Route("/api/customers")]
    [MapToApiVersion("2.0")]
    public IActionResult GetV2()
    {
        return Ok(new[]
        {
            new { id = 1, name = "Harsha", phone = "1234567890" },
            new { id = 2, name = "Avi", phone = "0987654321"}
        });
    }
}
