using System;
namespace Delegate
{
    public class Program
    {
        public void AddNumber(int a, int b) // non static function
        {
            Console.WriteLine(a+b);
        }
        public static string HelloName(string name) //static method
        {
            return "Hello "+name;
        }
        // public static string EmpDept(string dept) // making this anonymous
        // {
        //     return "Employee from "+ dept;
        // }
        public delegate string EmpDeptDelegate(string dept);
        public delegate string HelloDelegate(string name);
        public delegate void AddDelegate(int a,int b); //declaring delegate
        public static void Main(string[] args)
        {
            Program p= new Program();
            //p.AddNumber(100,50);
            // string str= Program.Hello("Harsha");
            // Console.WriteLine(str);
            AddDelegate ad= new AddDelegate(p.AddNumber); // instantiation of Add delegate
            HelloDelegate hd= new HelloDelegate(Program.HelloName); // // instantiation of Hello delegate
          // string st=hd("Ronnie"); //alling 1st way
           string st1= hd.Invoke("Harsha"); //calling 2nd way 
             Console.WriteLine(st1);
            ad.Invoke(100,50); // calling delegate
            // string empDeptStr= Program.EmpDept("HR");
            // Console.WriteLine(empDeptStr);
            EmpDeptDelegate edd = delegate (string dept)
            {
                 return "Employee from "+ dept;
            };
            string empDeptStr1= edd.Invoke("Human Resource department");
            Console.WriteLine(empDeptStr1);
        }
    }

}