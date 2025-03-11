using TestWebApi.Models;       // To access the Product model
using Microsoft.EntityFrameworkCore; // If using Entity Framework for database operations

namespace TestWebApi.Repositories
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Apple", Price = 10.0M },
            new Product { Id = 2, Name = "Banana", Price = 20.0M },
            new Product { Id = 3, Name = "citrus", Price = 11.0M },
            new Product { Id = 4, Name = "Doughnut", Price = 30.0M },
            new Product { Id = 5, Name = "Bread", Price = 9.0M }
        };

        // Get all products
        public List<Product> GetAll() => products;

        // Get a product by its ID
        public Product GetById(int id) => products.FirstOrDefault(p => p.Id == id);

        // Add a new product
        public void Add(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;  // Auto-increment the ID
            products.Add(product);
        }

        // Remove a product by ID
        public bool Remove(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        // Update an existing product
        public bool Update(int id, Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                return true;
            }
            return false;
        }
    }
}
