using System;
namespace Constructor
{

    
    public class Human
    {
        public string name;
        public int age;
        public Human()
        {
            Console.WriteLine("Default constructor called automatically");
        }
        public Human(string name, int age)
        {
            this.name= name;
            this.age=age;
        }
        public void sleep(){
            Console.WriteLine(name+" is sleeping");
            Console.WriteLine(age+"age");
        }
        public void work()
        {
            Console.WriteLine(name+" is working");
        }

    }
    public class Program
    {
        public static void Main()
        {
            Human h1= new Human("Harsha",20); //param.. Const.
            Human h2= new Human("Avi",25); ////param.. Const.
            Human h= new Human(); // no parameter constructor i.e defaultConstructor
            // h1.name="Harsha";
            // h1.age=20;
            // h2.name="Avi";
            // h2.age=18;
            h1.sleep();
            h2.work();


        }
    }
}
