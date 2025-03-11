using System;
namespace MachineMasters_AbstractClass
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("1.Permanent");
            Console.WriteLine("2.Temporary");
            Console.WriteLine("Choose the employee type");
            string choice= Console.WriteLine();
            
            Console.WriteLine("Enter employee Id");
            string id= Console.ReadLine();
            Console.WriteLine("Enter the name");
            string name= Console.ReadLine(); 
            Employee emp= new Employee();
            Console.WriteLine("Enter basic pay");
            double salary= Convert.ToDouble(Console.ReadLine());
                
           if(choice=="1")
            {
                
            bool check=emp.ValidateEmployeeId();
            if(check)
            {
                Permanent p= new Permanent
                {Id =id, 
                Name=name, 
                Salary=salary
                };
                //Console.WriteLine("Enter the DA");
                double Final_Perm=p.SalaryCalculation();
                Console.WriteLine($"Employee id: {p.Id}, Name: {p.Name}, Salary: "+Final_Perm);
            }
            else{
                Console.WriteLine("Invalid id");
            }
            }
            else if(choice =="2")
            {//double TempEmpSalary= HrsWorked * HrlyWages;
              Console.WriteLine("Enter the HrsWorked: ");
              int hrsWorked= int.Parse(Console.ReadLine());
              Console.WriteLine("Enter the HrlyWages: ");
              int hrlyWages= int.Parse(Console.ReadLine());
              Temporary t = new Temporary
              {Id= id, Name =name, 
              HrsWorked= hrsWorked,
              HrlyWages= hrlyWages
              };
              double Final_TempSalary=t.SalaryCalculation();
              Console.WriteLine($"Employee id: {p.Id}, Name: {p.Name}, Salary :"+Final_TempSalary);
              

            }

        }
    }
}
