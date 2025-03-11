using System;
using System.Collections.Generic;
using System.Linq;
namespace Dictionary
{
    public class Program{
        public static void Main()
        {        
            Dictionary<string, int> studentMarks = new Dictionary<string, int>(); 

        studentMarks.Add("Harsha", 90);
        studentMarks.Add("Avi", 85);
        studentMarks.Add("Ronnie", 95);

        if(studentMarks.ContainsKey("Harsha"))
        {
            Console.WriteLine("Exists");
        }
        else{
            Console.WriteLine("Not exists");
        }
        studentMarks.Remove("Ronnie");

         var sortedByKey = studentMarks.OrderBy(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);
         
        // foreach (var pair in studentMarks) {
        //     Console.WriteLine($"{pair.Key}: {pair.Value}");
        foreach (string key in studentMarks.Keys)
        {
            Console.WriteLine(key);
        Console.WriteLine(key+":"+studentMarks[key]);
        }
         Dictionary <string,int> dict= new Dictionary<string,int>();
    dict.Add("ha",1);
    dict.Add("rs",2);
    dict.Add("haa",3);
    foreach(string d in dict.Keys)
    Console.WriteLine(d+" "+dict[d]);
    var sortedDict= dict.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key,kvp=> kvp.Value);
    
    foreach(var pair in sortedDict)
    Console.Write(pair.Key+ " "+pair.Value);

        
        }
    }
}
