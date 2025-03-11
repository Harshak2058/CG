using System;
using System.Collections.Generic;
namespace MyWebApi.Models
{
    public class CustomerV1
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }

    
}