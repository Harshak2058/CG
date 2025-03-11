using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIFirst.Model;
using WEBAPIFirst.Interface;
namespace WEBAPIFirst.Repository
{
    public class CustomerV2Repository : ICustomerV2Repository
    {
        public static List<CustomerV2> lsCustomersV2 = new List<CustomerV2>{
            new CustomerV2{Id = 101, Name = "Harsha",Address = "Vizag",Email = "harsha@gmail.com",Phone = "90867678898"},
            new CustomerV2{Id = 102, Name = "Sha",Address = "Hyderabad",Email = "sha@gmail.com",Phone = "809678898"},
            new CustomerV2{Id = 103, Name = "Ronnie",Address = "Punjab",Email = "Ron@gmail.com",Phone = "70867678898"},
            new CustomerV2{Id = 104, Name = "Vardhan",Address = "Vizag",Email = "vardhan@gmail.com",Phone = "60867678898"}
        };
        public List<CustomerV2> GetAll()
        {
            return lsCustomersV2;
        }

        public CustomerV2 AddCustomer(CustomerV2 customer)
       {
        lsCustomersV2.Add(customer);
        return customer;
       }

       public bool UpdateCustomer(int id ,CustomerV2 customer)
       {
        var exiting = lsCustomersV2.FirstOrDefault(c=>c.Id == id);
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
        var userToDelete = lsCustomersV2.FirstOrDefault(c=>c.Id == id);
        if(userToDelete == null)
        {
            return false;
        }
        lsCustomersV2.Remove(userToDelete);
        return true;
       }
    }
}