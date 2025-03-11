 using System;
 using System.Collections;
 namespace ArrayListt{
 class Program {
    static void Main() {
        ArrayList myList= new ArrayList();//non gneric
    myList.Add("Harsha");
    myList.Add("Avi");
    myList.Add("ronnie");
     Console.WriteLine("ArrayList Elements:");
          Console.WriteLine("---"+myList.Capacity+"---");
        for (int i = 0; i < myList.Count; i++) 
        {
            Console.WriteLine(myList[i]);
        }
         Console.WriteLine("Contains 'Harsha? " + myList.Contains("Harsha"));
        ArrayList aList= new ArrayList(10); //making initial capacity as 10
        aList.Add("Harsha");
        aList.Add(120);
        aList.Add("Avi"); 
        Console.WriteLine("Elements are:");
        Console.WriteLine("---"+aList.Capacity+"---");
       foreach (object obj in aList)
       Console.Write(obj+" ");
       Console.WriteLine();
       aList.Insert(1,"Ronnie");
       foreach (object obj in aList)
       Console.Write(obj+" ");
       Console.WriteLine();
       aList.Remove(120);
       foreach (object obj in aList)
       Console.Write(obj+" ");
       Console.WriteLine();
       aList.RemoveAt(1);
       foreach (object obj in aList)
       Console.Write(obj+" ");
       Console.WriteLine();
    }
 }
 }
 