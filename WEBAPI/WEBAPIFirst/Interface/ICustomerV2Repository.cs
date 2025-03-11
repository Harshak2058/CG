using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIFirst.Model;

namespace WEBAPIFirst.Interface
{
    public interface ICustomerV2Repository
    {
        List<CustomerV2> GetAll();
        CustomerV2 AddCustomer(CustomerV2 customer);
        bool UpdateCustomer(int id ,CustomerV2 customer);

        bool DeleteCustomer(int id);
    }
}