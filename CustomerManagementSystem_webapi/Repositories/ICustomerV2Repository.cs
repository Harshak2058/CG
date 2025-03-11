using System;
using System.Collections.Generic;

using CustomerManagementSystem_webapi.Interfaces;
namespace CustomerManagementSystem_webapi.Repositories
{
    public interface ICustomerV2Repository
    {
        List<CustomerV2> GetAll();
    }
}