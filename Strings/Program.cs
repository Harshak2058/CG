using System;
class HelloWorld {
  static void Main() {
      string s1= "harsha";
    string s2=s1.Insert(6," Ronnie");
    string s3= s2.Remove(11);
    int s4=s2.IndexOf('s');
    
    Console.WriteLine(s1);
    Console.WriteLine(s2);
    Console.WriteLine(s3);
    Console.WriteLine("index position of that character in string is "+s4);
    
    int s5= s2.LastIndexOf('h');
    Console.WriteLine("Last of position of that character in string is "+ s5);
    
    string s6= "Mani Bharti";
    Console.WriteLine(s6.Replace("Bharti", "Adorable"));
    
    string s7= "Adorable Mani Bharti";
    string[] substring= s7.Split(' ');
    Console.WriteLine("----substring items below----");
    Console.WriteLine("-----------------------------");
    foreach(var item in substring)
    {   
        
        Console.WriteLine(item);
    }
    
    
    
  }
}
