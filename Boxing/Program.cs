using System;

class Program {
    static void Main() {
        int num = 10;
        object obj = num;  // box
        Console.WriteLine($"Box value: {obj}");

       
        int unboxedNum = (int)obj;  // unbox
        Console.WriteLine($"Unbox value: {unboxedNum}");
    }
}

