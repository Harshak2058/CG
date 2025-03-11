using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Litwarelib
{
    public class Program
    {
        public static void Main(string[] args){
          Console.Write("Enter Employee Number: ");
        int empNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string empName = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee employee = new Employee(empNo, empName, salary);

        Console.WriteLine("\nEmployee Salary Details:");
        employee.DisplaySalaryDetails();
        }
    }
}