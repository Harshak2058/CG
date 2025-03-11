using System;
using System.Collections.Generic;

namespace CMS
{
    class Program
    {
        static CustomerBLL customerBLL = new CustomerBLL();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nCustomer Management System");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customers");
                Console.WriteLine("3. Search Customer");
                Console.WriteLine("4. Remove Customer");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ViewCustomers();
                        break;
                    case 3:
                        SearchCustomer();
                        break;
                    case 4:
                        RemoveCustomer();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter Customer ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Pincode: ");
            string pincode = Console.ReadLine();

            try
            {
                customerBLL.AddCustomer(id, name, city, age, phone, pincode);
                Console.WriteLine("Customer added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ViewCustomers()
        {
            List<Customer> customers = customerBLL.GetCustomers();
            Console.WriteLine("\nCustomer List:");
            Console.WriteLine(string.Format("| {0,-10} | {1,-20} | {2,-15} | {3,-5} | {4,-12} | {5,-8} |",
            "ID", "Name", "City", "Age", "Phone", "Pincode"));  
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            foreach (var customer in customers)
            {
                string output = string.Format("| {0,-10} | {1,-20} | {2,-15} | {3,-5} | {4,-12} | {5,-8} |",customer.CustomerID, customer.CustomerName, customer.City, customer.Age, customer.Phone, customer.Pincode);
                Console.WriteLine(output);

            }
        }

        static void SearchCustomer()
        {
            Console.Write("Enter Customer ID (or press Enter to skip): ");
            string idInput = Console.ReadLine();
            int? id = string.IsNullOrEmpty(idInput) ? (int?)null : int.Parse(idInput);

            Console.Write("Enter Customer Name (or press Enter to skip): ");
            string name = Console.ReadLine();

            List<Customer> result = customerBLL.SearchCustomers(id, name);
            if (result.Count > 0)
            {
                Console.WriteLine("\nSearch Results:");
                foreach (var customer in result)
                {
                    Console.WriteLine(customer);
                }
            }
            else
            {
                Console.WriteLine("No customers found.");
            }
        }

        static void RemoveCustomer()
        {
            Console.Write("Enter Customer ID to Remove: ");
            int id = int.Parse(Console.ReadLine());

            if (customerBLL.RemoveCustomer(id))
                Console.WriteLine("Customer removed successfully.");
            else
                Console.WriteLine("Customer not found.");
        }
    }
}
