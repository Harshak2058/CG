using System;

abstract class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public bool ValidateEmployeeId()
    {
        if (Id.Length == 5 && Id.StartsWith("EM") && int.TryParse(Id.Substring(2), out _))
        {
            return true;
        }
        return false;
    }

    public abstract Employee SalaryCalculation();
}

class Permanent : Employee
{
    public double BasicPay { get; set; }

    public override Employee SalaryCalculation()
    {
        double DA = 0.5 * BasicPay;
        double HRA = 0.3 * BasicPay;
        Salary = BasicPay + DA + HRA;
        return this;
    }
}

class Temporary : Employee
{
    public int HrsWorked { get; set; }
    public int HrlyWages { get; set; }

    public override Employee SalaryCalculation()
    {
        Salary = HrsWorked * HrlyWages;
        return this;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("1.Permanent");
        Console.WriteLine("2.Temporary");
        Console.WriteLine("\nChoose the employee type");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee id");
        string empId = Console.ReadLine();

        if (choice == 1)
        {
            Permanent emp = new Permanent();
            emp.Id = empId;

            if (!emp.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
                return;
            }

            Console.WriteLine("Enter the name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter basic pay");
            emp.BasicPay = double.Parse(Console.ReadLine());
            emp.SalaryCalculation();

            Console.WriteLine($"Employee id : {emp.Id},  Name : {emp.Name},  Salary : {emp.Salary}");
        }
        else if (choice == 2)
        {
            Temporary emp = new Temporary();
            emp.Id = empId;

            if (!emp.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
                return;
            }

            Console.WriteLine("Enter the name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter hours worked");
            emp.HrsWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter hourly wages");
            emp.HrlyWages = int.Parse(Console.ReadLine());
            emp.SalaryCalculation();

            Console.WriteLine($"Employee id : {emp.Id},  Name : {emp.Name},  Salary : {emp.Salary}");
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
