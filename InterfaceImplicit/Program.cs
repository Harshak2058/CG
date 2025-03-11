using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks!");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Speak();  

        IAnimal animal = new Dog();
        animal.Speak();
    }
}

