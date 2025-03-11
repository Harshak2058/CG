using System;
using System.Collections.Generic;
using System.Linq;

namespace CMS
{
    public class CustomerDAL
    {
        private static List<Customer> customers = new List<Customer>();


        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        
        public List<Customer> GetCustomers() 
        {
            return customers;
        }

        public List<Customer> SearchCustomers(int? id = null, string name = null)
        {
            return customers.Where(c =>
                (!id.HasValue || c.CustomerID == id.Value) &&
                (string.IsNullOrEmpty(name) || c.CustomerName.Contains(name, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public bool RemoveCustomer(int id)
        {
            var customer = GetCustomerById(id);
            if (customer != null)
            {
                customers.Remove(customer);
                return true;
            }
            return false;
        }
    }
}
