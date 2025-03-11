using System;
using System.Collections.Generic;
namespace MyWebApi.Models
{
        public class CustomerV2 : CustomerV1
    {
        public string Email { get; set; } = string.Empty;
    }
}
