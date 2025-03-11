using CMS_webapi.Models;       // To access the Product model
using Microsoft.EntityFrameworkCore; // If using Entity Framework for database operations
using System.Collections.Generic;
using System.Linq;

namespace CMS_webapi.Repositories
{
    public interface ICustomerV1Repository
    {
        List<CustomerV1> GetAll();
        CustomerV1 GetById(int id);              
        void AddCustomer(CustomerV1 customer);
        bool UpdateCustomer(CustomerV1 customer); 
        bool RemoveCustomer(int id);
    }
}
