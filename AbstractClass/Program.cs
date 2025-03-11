using System;
namespace AbstractClass
{
   
    public abstract class Vehicle
    {
       public int speed = 0;
        public virtual void go()
        {
            Console.WriteLine($"vehicle is at {speed}");
        }
    }

    public class Bike : Vehicle
    {
        public int wheels=2;
       public int MaxSpeed=50;
       public override void go(){
            Console.WriteLine($"Going with {MaxSpeed} as it has {wheels} wheels");
        }
    }
    public class Car : Vehicle
    {
        int wheels=4;
        int MaxSpeed= 100;
        public override void go()
        {
            Console.WriteLine($"Moving with {MaxSpeed} as it has {wheels} wheels");
        }
    }
     public class Program
    {
        public static void Main()
        {
           // Console.WriteLine("Hai");
           Bike b=new Bike();
           b.go();
           Car c=new Car();
           c.go();
        }
    }

}
