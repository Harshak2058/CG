using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectInitializer_CollectionInitializer
{
    public class MyClass
    {
       public List<string> Items { get; set; }

          public MyClass(List<string> items)
          {
             this.Items = items;
          }
}
}