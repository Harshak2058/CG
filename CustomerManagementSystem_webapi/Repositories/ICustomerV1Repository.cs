using System;
using System.Collections.Generic;
using CustomerManagementSystem_webapi.Interfaces;


namespace CustomerManagementSystem_webapi.Repositories
{
    public interface ICustomerV1Repository
    {
        List<CustomerV1> GetAll();
        CustomerV1? GetCustomerById(int id);
        void AddCustomer(CustomerV1 customer);
        void UpdateCustomer(CustomerV1 customer);
        void DeleteCustomer(int id);
        
    }
}