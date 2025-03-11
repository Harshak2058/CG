using Microsoft.AspNetCore.Mvc; // For Controller, ActionResult, HTTP methods
using TestWebApi.Repositories;   // For using ProductRepository (dependency injection)
using TestWebApi.Models;        // For using your Product model

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _repository = new ProductRepository();

        // Get all products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        // Get a product by ID
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // Add a new product
        [HttpPost]
        public ActionResult Create([FromBody] Product product)
        {
            _repository.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // Update an existing product
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Product product)
        {
            var success = _repository.Update(id, product);
            if (!success)
                return NotFound();
            return NoContent();  // 204 No Content
        }

        // Remove a product
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var success = _repository.Remove(id);
            if (!success)
                return NotFound();
            return NoContent();  // 204 No Content
        }
    }
}
