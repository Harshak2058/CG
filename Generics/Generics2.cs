using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class Generics2<T> //public class Generics2
    {
        public void Add(T a, T b) //public void Add<T>(T a, T b)
        {
            dynamic d1=a;
            dynamic d2=b;
            Console.WriteLine(d1+d2);
        }
        public void Sub(T a, T b)// public void Sub<T>(T a, T b)
        {
             dynamic d1=a;
            dynamic d2=b;
            Console.WriteLine(d1-d2);
        }
        public void Mul(T a,T b) //public void Mul<T>(T a,T b)
        {
            dynamic d1=a;
            dynamic d2=b;
            Console.WriteLine(d1*d2);
        }
        public void Div(T a , T b) // public void Div<T>(T a , T b)
        {
             dynamic d1=a;
            dynamic d2=b;
            Console.WriteLine(d1/d2);
        }
        // static void Main()
        // {
        //     Generics2 obj= new Generics2();
        //     obj.Add(10,20); //obj.Add<int>(10,20); 
        //     obj.Sub(20,10); //obj.Sub<int>(20,10);
        //     obj.Mul(10,20); //obj.Mul<int>(10,20);
        //     obj.Div(20,10); //obj.Div<int>(20,10);
        // }
    }
}