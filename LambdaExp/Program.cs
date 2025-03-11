using System;


namespace LambdaExp
{
    public class Program
    {
        
        // public static string EmpDept(string dept) // making this anonymous
        // {
        //     return "Employee from "+ dept;
        // }
        public delegate string EmpDeptDelegate(string dept);
        public static void Main(string[] args)
        {
            //Program p= new Program();

            EmpDeptDelegate edd = (dept)=>  //delegate (string dept)  // using LAMBDA EXPRESSION here
            {
                 return "Employee from "+ dept;
            };
            string empDeptStr1= edd.Invoke("Human Resource department");
            Console.WriteLine(empDeptStr1);

        }
    }

}