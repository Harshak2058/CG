using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineMasters_AbstractClass
{
    public class Permanent: Employee
    {
        public double BasicPay{get;set;}

        public override Employee SalaryCalculation()
        {
            
            double DA= (BasicPay)*0.5, 
            HRA= (BasicPay)*0.3;
            Salary= BasicPay+DA+HRA;
            return Salary;

        }
    }
}