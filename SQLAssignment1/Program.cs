using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string City { get; set; }
}

class Program
{
    public static void Main(string[] args)

    {
        List<Employee> empList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.ParseExact("16/11/1984", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("08/06/2011", "dd/MM/yyyy", null), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.ParseExact("20/08/1984", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("07/07/2012", "dd/MM/yyyy", null), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.ParseExact("14/11/1987", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("12/04/2015", "dd/MM/yyyy", null), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title="SE",DOB = DateTime.ParseExact("03/06/1990", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("02/02/2016", "dd/MM/yyyy", null), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.ParseExact("08/03/1991", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("02/02/2016", "dd/MM/yyyy", null), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.ParseExact("07/11/1989", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("08/08/2014", "dd/MM/yyyy", null), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.ParseExact("02/12/1989", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("01/06/2015", "dd/MM/yyyy", null), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.ParseExact("11/11/1993", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("06/11/2014", "dd/MM/yyyy", null), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.ParseExact("12/08/1992", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("03/02/2014", "dd/MM/yyyy", null), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.ParseExact("12/04/1991", "dd/MM/yyyy", null), DOJ = DateTime.ParseExact("02/01/2016", "dd/MM/yyyy", null), City = "Pune" }
        };
//a
        Console.WriteLine("All Employees:");
        DisplayEmployees(empList);
//b
        Console.WriteLine("\nEmployees not in Mumbai:");
        DisplayEmployees(empList.Where(e => e.City != "Mumbai"));
//c
        Console.WriteLine("\nEmployees with title 'AsstManager':");
        DisplayEmployees(empList.Where(e => e.Title == "AsstManager"));
//d
        Console.WriteLine("\nEmployees whose last name starts with 'S':");
        DisplayEmployees(empList.Where(e => e.LastName.StartsWith("S")));
//e
        Console.WriteLine("\nEmployees who joined before 1/1/2015:");
        DisplayEmployees(empList.Where(e => e.DOJ < new DateTime(2015, 1, 1)));

//f
        Console.WriteLine("\nEmployees born after 1/1/1990:");
        DisplayEmployees(empList.Where(e => e.DOB > new DateTime(1990, 1, 1)));
       
//g
        Console.WriteLine("\nEmployees with designation 'Consultant' or 'Associate':");
        DisplayEmployees(empList.Where(e => e.Title == "Consultant" || e.Title == "Associate"));
        
//h
        Console.WriteLine($"\nTotal number of employees: {empList.Count}");
//i
        
        Console.WriteLine($"\nTotal employees in Chennai: {empList.Count(e => e.City == "Chennai")}");

//j

        Console.WriteLine($"\nHighest Employee ID: {empList.Max(e => e.EmployeeID)}");
        
//k
        Console.WriteLine($"\nTotal employees who joined after 1/1/2015: {empList.Count(e => e.DOJ > new DateTime(2015, 1, 1))}");
//l
       Console.WriteLine($"\nTotal employees whose designation is not \"Associate\": {empList.Count(e => e.Title != "Associate")}");
//m
        Console.WriteLine("\nTotal employees based on city:");
        var cities = empList.Select(e => e.City).Distinct();
        foreach (var city in cities)
            Console.WriteLine($"{city}: {empList.Count(e => e.City == city)}");
//n
        Console.WriteLine("\nTotal employees based on city and title:");
        var cityTitleGroups = empList.Select(e => new { e.City, e.Title }).Distinct();
        foreach (var group in cityTitleGroups)
            Console.WriteLine($"{group.City} - {group.Title}: {empList.Count(e => e.City == group.City && e.Title == group.Title)}");
//o
        var youngestEmployee = empList.OrderByDescending(e => e.DOB).First();
        Console.WriteLine($"\nYoungest Employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}, DOB: {youngestEmployee.DOB:dd/MM/yyyy}");

        Console.ReadLine();
    }

    static void DisplayEmployees(IEnumerable<Employee> employees)
    {
        foreach (var e in employees)
        {
            Console.WriteLine($"{e.EmployeeID}, {e.FirstName} {e.LastName}, {e.Title}, DOB: {e.DOB:dd/MM/yyyy}, DOJ: {e.DOJ:dd/MM/yyyy}, City: {e.City}");
        }
    }
}
