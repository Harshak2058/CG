using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomException
{
    public class Person
    {
        public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        if (age < 18)
        {
            throw new AgeException("Age must be 18 or above.");
        }
        this.Name = name;
        this.Age = age;
    }
        
    }
}