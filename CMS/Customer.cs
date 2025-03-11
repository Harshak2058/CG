using System;

namespace CMS
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Pincode { get; set; }
        
        public Customer(int id, string name, string city, int age, string phone, string pincode)
        {
            CustomerID = id;
            CustomerName = name;
            City = city;
            Age = age;
            Phone = phone;
            Pincode = pincode;
        }

        public override string ToString()
        {
            return $"ID: {CustomerID}, Name: {CustomerName}, City: {City}, Age: {Age}, Phone: {Phone}, Pincode: {Pincode}";
        }
    }
}
