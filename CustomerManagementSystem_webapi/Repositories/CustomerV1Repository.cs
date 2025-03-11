using System;
using System.Collections.Generic;
using CustomerManagementSystem_webapi.Interfaces;
using CustomerManagementSystem_webapi.Models;

namespace CustomerManagementSystem_webapi.Repositories
{
    public class CustomerV1Repository : ICustomerV1Repository
    
    {
        private static List<CustomerV1> customers=  new List<CustomerV1>
        {
            new CustomerV1{Id=1, Name="Harsha", Address="Vizag"},
            new CustomerV1{Id=2,nameof="Ronnie",Address="Hyderabad"}
        };
        public List<CustomerV1>GetAll()
        {
            return customers;
        }
        public void Add(CustomerV1 customer)
        {
            customers.Add(customer);
        }
        
    }
}