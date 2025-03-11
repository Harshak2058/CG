using System;
using System.Collections.Generic;
using MyWebApi.Models;
using MyWebApi.Interfaces;
using System.Linq;
namespace MyWebApi.Repositories
{
    public class CustomerV2Repository : ICustomerV2Repository
    {
        private readonly List<CustomerV2> _customers = new();

        public List<CustomerV2> GetAll()
        {
            return _customers;
        }

        public CustomerV2 GetCustomerById(int id)
        {
            return _customers.Find(c => c.Id == id);
        }

        public void AddCustomer(CustomerV2 customer)
        {
            _customers.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            var customer = _customers.Find(c => c.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer);
            }
        }
    }
}
