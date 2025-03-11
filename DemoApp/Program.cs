using newdemoapp;
 
public class Program {
 
    public static void Main(string[] args){
 
                Console.WriteLine("Enter the ID of Employee");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Employee Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the Employee Department");
        string department = Console.ReadLine();


        Employee emp = new Employee(id, name, department);

        emp.DisplayDetails();
    }
}