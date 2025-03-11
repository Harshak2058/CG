using System;
using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        public bool Compare<T>(T a, T b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            Program obj1= new Program();
            bool result1= obj1.Compare<int>(12,23); //type safe //dont req boxing and unboxing 
            Console.WriteLine(result1);
             bool result2= obj1.Compare<float>(12.89f,23.87f); 
            Console.WriteLine(result2);

            Generics2 obj= new Generics2();
            obj.Add(10,20);
            obj.Sub(20,10);
            obj.Mul(10,20);
            obj.Div(20,10);
        

        }
    }
}
