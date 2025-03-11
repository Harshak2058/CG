using System;

namespace Interface
{

    public class Program
    {
       
      interface Predator
      {
        void hunt();
 
      }  
      interface Prey
      {
        void flee();

      }
      class Lion : Predator
      {
        public void hunt(){
        Console.WriteLine("Lion is hunting");
        }

      } 
      class Deer : Prey
      {
        public void flee()
        {
            Console.WriteLine("Deer is running to save its life");
        }


      } 
      class Man : Predator, Prey
      {
        public void hunt()
        {
            Console.WriteLine("Man started hunting");
        }
        public void flee()
        {
            Console.WriteLine("Man started runnning");
        }
      } 
 public static void Main(string[] args)
        {
            //Console.WriteLine("Hai");
            // Lion l=new Lion();
            // l.hunt();
            // Deer d=new Deer();
            // d.flee();
            Man m=new Man();
            m.flee();
            m.hunt();

        }
  
    }
}
