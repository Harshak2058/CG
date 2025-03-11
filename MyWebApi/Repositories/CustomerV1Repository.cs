using System;
using System.Collections.Generic;
using System.Linq;
using MyWebApi.Models;

namespace MyWebApi.Repositories
{
    public class CustomerV1Repository : ICustomerV1Repository
    {
       
        private List<CustomerV1> customers = new List<CustomerV1>
        {
            new CustomerV1 { Id = 1, Name = "Harsha", Address = "mumbai" },
            new CustomerV1 { Id = 2, Name = "Ronnie", Address = "hyderaebad" }
        };

        public List<CustomerV1> GetAll()
        {
            return customers;
        }

        // public CustomerV1? GetCustomerById(int id)
        // {
        //     return customers.FirstOrDefault(c => c.Id == id);
        // }

        public void Add(CustomerV1 customer)
        {
            customers.Add(customer);
        }

        public void UpdateCustomer(CustomerV1 customer)
        {
            var existingCustomer = customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.Address = customer.Address;
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                customers.Remove(customer);
            }
        }
    }
}
