using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIFirst.Model;

namespace WEBAPIFirst.Interface
{
    public interface ICustomerV1Repository
    {
        List<CustomerV1> GetAll();
        CustomerV1 AddCustomer(CustomerV1 customer);
        bool UpdateCustomer(int id ,CustomerV1 customer);

        bool DeleteCustomer(int id);
    }
}