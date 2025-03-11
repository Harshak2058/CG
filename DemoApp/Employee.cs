using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp
{
    public class Employee
    {
         public int Id { get; set; }
    public string Name { get; set; }

    public string Department { get; set; }


    public Employee(int Id, string Name, string Department)
    {
        this.Id = Id;
        this.Name = Name;
        this.Department = Department;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"{this.Id} : {this.Name} : {this.Department}");
    }
}
}