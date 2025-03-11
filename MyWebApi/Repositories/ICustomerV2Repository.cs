using System.Collections.Generic;
using MyWebApi.Models;

namespace MyWebApi.Repositories
{
    public interface ICustomerV2Repository
    {
        List<CustomerV2> GetAll();
    }
}
