using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIFirst.Model;
using WEBAPIFirst.Interface;
namespace WEBAPIFirst.Repository
{
    public class CustomerV1Repository : ICustomerV1Repository
    {
        public static List<CustomerV1> lsCustomersV1 = new List<CustomerV1>
        {
            new CustomerV1 { Id = 1, Name = "Harsha", Address = "Vizag"},
            new CustomerV1 { Id = 2,Name = "Sha", Address = "Hyderabad"},
            new CustomerV1 { Id = 3, Name = "Ronnie",Address = "Punjab"}
        };
    
        public List<CustomerV1> GetAll()
        {
            return lsCustomersV1;
        }

       public CustomerV1 AddCustomer(CustomerV1 customer)
       {
        lsCustomersV1.Add(customer);
        return customer;
       }

       public bool UpdateCustomer(int id ,CustomerV1 customer)
       {
        var exiting = lsCustomersV1.FirstOrDefault(c=>c.Id == id);
        if(exiting == null)
        {
            return false;
        }
        exiting.Name = customer.Name;
        exiting.Address = customer.Address;
        return true;
       }

       public bool DeleteCustomer(int id)
       {
        var userToDelete = lsCustomersV1.FirstOrDefault(c=>c.Id == id);
        if(userToDelete == null)
        {
            return false;
        }
        lsCustomersV1.Remove(userToDelete);
        return true;
       }
    }
}