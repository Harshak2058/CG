using CMS_webapi.Models;       // To access the Product model
using Microsoft.EntityFrameworkCore; // If using Entity Framework for database operations

namespace CMS_webapi.Repositories
{
    public class CustomerV1Repository : ICustomerV1Repository
    {
        private static List<CustomerV1> _customers = new List<CustomerV1>
        {
            new CustomerV1 { Id = 1, Name = "Harsha", Address = "Vizag" },
            new CustomerV1 { Id = 2, Name = "Ronnie", Address = "Hyderabad" },
            new CustomerV1 { Id = 3, Name = "Varsha", Address = "Mumbai" },
            new CustomerV1 { Id = 4, Name = "sha", Address = "Punjab" },
            new CustomerV1 { Id = 5, Name = "shanu", Address = "Himachal" }
        };

        public List<CustomerV1> GetAll()
        {
            return _customers;
        }

        public CustomerV1 GetById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void AddCustomer(CustomerV1 customer)
        {
            _customers.Add(customer);
        }

        public bool UpdateCustomer(CustomerV1 updatedCustomer)
        {
            var existingCustomer = _customers.FirstOrDefault(c => c.Id == updatedCustomer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = updatedCustomer.Name;
                existingCustomer.Address = updatedCustomer.Address;
                return true;
            }
            return false;
        }

        public bool RemoveCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer);
                return true;
            }
            return false;
        }
    }
}

