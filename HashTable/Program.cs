 using System;
 using System.Collections;
 namespace HashTable{
 class Program {
    static void Main() {
     Hashtable ht= new Hashtable();
     ht.Add("Name", "Harsha");
     ht.Add("EmpId", 101);
     ht.Add("EmpDept", "HR");
     ht.Add("Salary", 50000);
     ht.Add("MgrId", "M101");
     ht.Add("Phone",9999999999);
     ht.Add("Email", "h@gmail.com");
     ht.Add("Location", "Hyderabad");
     foreach(object key in ht.Keys)
     Console.WriteLine(key+":"+ht[key]);

     Console.WriteLine("Harsha".GetHashCode());
    }
 }
 }
 //BECAUSE IT GENERATES HASHCODE IT WONT GENERATE IN SEQUENCE ORDER but fetching is very faster because of hashcode
