using CMS_webapi.Models;

namespace CMS_webapi.Repositories
{
    public interface ICustomerV2Repository
    {
        List<CustomerV2> GetAll();
        CustomerV2 GetById(int id);
        void AddCustomer(CustomerV2 customer);
        bool UpdateCustomer(CustomerV2 customer);
        bool RemoveCustomer(int id);
    }
}