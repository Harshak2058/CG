using System;
using System.Collections.Generic;
namespace CustomerManagementSystem_webapi.Repositories
{
    public class CustomerV2Repository : ICustomerV2Repository
    
    {
        private static List<CustomerV2> customers = new List<CustomerV2>
        {
            new CustomerV2{Id=1, Name="Harsha", Address="Vizag", Email="har@gmail.com",Phone="1234567890"},
            new CustomerV2{Id=2, Name="Ronnie", Address="Hyderabad", Email="ron@gmail.com",Phone="1234567899"}
        };
        public List<CustomerV2>GetAll()
        {
            return customers;
        }
        public void Add(CustomerV2 customer)
        {
            customers.Add(customer);
        }
        
    }
}