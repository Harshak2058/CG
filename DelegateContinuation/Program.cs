using System;
namespace DelegateContinuation
{
   public delegate double delegate1(int x, float y, double z);
    public class Program
    {   
        //public static void delegate2(int x, float y, double z);
        //public static bool delegate3(string str);
        // 1) func 2)action 3)Predicate
        public static double AddNumber1(int x, float y, double z)
        {
            return x+y+z;
        }
        public static void AddNumber2(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool CheckLength(string str)
        {
            if(str.Length >3)
            {
                return true;
            }
            return false;
        }
        public delegate string EmpDeptDelegate(string dept);
        public static void Main(string[] args)
        {
            Program p= new Program();
            // delegate1 d1 = new delegate1(AddNumber1); 
            // double result=d1.Invoke(10,5.5f,4.65);
            // Console.WriteLine(result);
            Func<int, float, double, double> d1obj = new Func<int, float, double, double>(AddNumber1);
            double result1 = d1obj.Invoke(10, 5.5f, 4.65);
            Console.WriteLine("Result 1 using Func: " + result1);
            Action<int, float, double> d2obj = AddNumber2;
            Console.WriteLine("using Action");
            d2obj.Invoke(10,5.5f,4.65);
            Predicate<string> d3obj =  CheckLength;
            bool status= d3obj.Invoke("Harsha Ronnie");
            Console.WriteLine(status);
        }
    }

}