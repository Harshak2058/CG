using System;
using System.Collections.Generic;
namespace PractiseCollections
{
    public class Program
    {
        static void Main()
        {
            List<string> li = new List<string>();
            li.Add("HA");
            li.Add("RS");
            li.Add("HA");
            foreach(object obj1 in li)
            Console.Write(obj1+" ");
            
        }
    }
}
