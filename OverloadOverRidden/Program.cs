using System;

class OverloadingExample
{
    public void ShowMessage()
    {
        Console.WriteLine("Hello, this is the first method!");
    }

    public void ShowMessage(string name)
    {
        Console.WriteLine("Hello, " + name + "! This is an overloaded method.");
    }
}

class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Base Class Display Method.");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Derived Class Overridden Display Method.");
    }
}

class Program
{
    static void Main()
    {
        OverloadingExample obj1 = new OverloadingExample();
        obj1.ShowMessage();
        obj1.ShowMessage("Harshavardhan");

        Console.WriteLine();

        BaseClass obj2 = new DerivedClass();
        obj2.Display();
    }
}

