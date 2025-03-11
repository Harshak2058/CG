using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAssignmentRashmi
{
    public class SavingsAccount : IAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, double balance, double interestRate)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        InterestRate = interestRate;
    }
    
    public double CalculateInterest()
    {
        double interest = (Balance * InterestRate) / 100;
        if (Balance < 1000)
        {
            interest -= (0.1 / 100) * Balance;
        }
        return interest;
    }
}
}