using CMS_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS_webapi.Repositories
{
    public class CustomerV2Repository : ICustomerV2Repository
    {
        private static List<CustomerV2> _customers = new List<CustomerV2>
        {
            new CustomerV2 { Id = 1, Name = "Harsha", Address = "Vizag", Email = "har@gmail.com", Phone = "1234567890" },
            new CustomerV2 { Id = 2, Name = "Ronnie", Address = "Hyderabad", Email = "ron@gmail.com", Phone = "9876543210" }
        };

        public List<CustomerV2> GetAll()
        {
            return _customers;
        }

        public CustomerV2 GetById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void AddCustomer(CustomerV2 customer)
        {
            _customers.Add(customer);
        }

        public bool UpdateCustomer(CustomerV2 updatedCustomer)
        {
            var existingCustomer = _customers.FirstOrDefault(c => c.Id == updatedCustomer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = updatedCustomer.Name;
                existingCustomer.Address = updatedCustomer.Address;
                existingCustomer.Email = updatedCustomer.Email;
                existingCustomer.Phone = updatedCustomer.Phone;
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
