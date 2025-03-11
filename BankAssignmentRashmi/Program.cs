using System;

namespace BankAssignmentRashmi
{
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Savings account");
            Console.WriteLine("2. Checking account");
            Console.Write("Enter the choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter the account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter the balance amount: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            double interestRate = double.Parse(Console.ReadLine());

            IAccount account;

            if (choice == "1")
            {
                account = new SavingsAccount(accountNumber, balance, interestRate);
            }
            else if (choice == "2")
            {
                account = new CheckingAccount(accountNumber, balance, interestRate);
            }
            else
            {
                Console.WriteLine("Invalid option selected");
                continue;
            }

            Console.WriteLine("Interest amount is " + account.CalculateInterest());
        }
    }
}
}
