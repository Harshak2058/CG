using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineMasters_AbstractClass
{
    public abstract class Employee
    {
        public string Id{get;set;}
        public string Name{get;set;}
        public double Salary{get;set;}

        public bool ValidateEmployeeId()
        {
            if(Id.Length==5 && Id.StartsWith("EM") && int.TryParse(Id.Substring(2),out _))//EM101
            return true;
            return false;
        }
        public abstract Employee SalaryCalculation();
    }
}