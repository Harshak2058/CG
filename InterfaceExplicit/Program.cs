using System;

interface IAnimal
{
    void Speak();
}

interface IRobot
{
    void Speak();
}

class Cyborg : IAnimal, IRobot
{
    void IAnimal.Speak()  //exp impl
    {
        Console.WriteLine("Cyborg speaks like an animal!");
    }

    void IRobot.Speak()  //exp impl
    {
        Console.WriteLine("Cyborg speaks like a robot!");
    }
}

class Program
{
    static void Main()
    {
        Cyborg cyborg = new Cyborg();
        // cyborg.Speak();  //Cannot call explicitly implemented methods directly

        IAnimal animal = cyborg;
        animal.Speak();  

        IRobot robot = cyborg;
        robot.Speak();  
    }
}

