using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineMasters_AbstractClass
{
    public class Temporary : Employee
    {
        public int HrsWorked{get;set;}
        public int HrlyWages{get;set;}

         public override Employee SalaryCalculation()
        {
            Salary= HrsWorked * HrlyWages;
            return Salary;
            
        }
    }
}