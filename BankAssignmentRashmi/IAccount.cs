using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAssignmentRashmi
{
    public interface IAccount
{
    string AccountNumber { get; set; }
    double Balance { get; set; }
    double InterestRate { get; set; }
    double CalculateInterest();
}
}