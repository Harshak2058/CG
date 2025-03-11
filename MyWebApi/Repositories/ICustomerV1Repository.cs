using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyWebApi.Repositories
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