using System;
class Program
{
    public static void Main()
    {
        int[] arr= new int[10];
        Array.Resize(ref arr,25);
       // int len= arr.Length();
        Console.WriteLine(arr.Length);

    }
 }
//Collections increases the size
// they insert values into ther middle
//Deleting or removing values from the middle
/*
non generic classes:
System.Collections : Stack, Queue, LinkedList, SortedList, ArrayList, Hashable