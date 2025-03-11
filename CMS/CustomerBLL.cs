using System;
using System.Collections.Generic;

namespace CMS
{
    public class CustomerBLL
    {
        private CustomerDAL dal = new CustomerDAL();

        public void AddCustomer(int id, string name, string city, int age, string phone, string pincode)
        {
            if (age < 18)
                throw new Exception("Age must be 18 or above.");
            if (phone.Length != 10)
                throw new Exception("Phone number must be 10 digits.");

            Customer customer = new Customer(id, name, city, age, phone, pincode);
            dal.AddCustomer(customer);
        }

        public List<Customer> GetCustomers()
        {
            return dal.GetCustomers();
        }

        public List<Customer> SearchCustomers(int? id = null, string name = null)
        {
            return dal.SearchCustomers(id, name);
        }

        public bool RemoveCustomer(int id)
        {
            return dal.RemoveCustomer(id);
        }
    }
}
