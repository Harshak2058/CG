using System;
namespace BankTrans_Exception
{
    public class Program
    {
        public static void Main()
        {
            //Account account= new Account();
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("Enter the choice");
            string choice= Console.ReadLine();
            Console.WriteLine("Enter the account number");
                string accountNumber= Console.ReadLine();
                Console.WriteLine("Enter the balance");
                decimal balance= Convert.ToDecimal(Console.ReadLine());
                Account account= new Account{
                AccountNumber= accountNumber, Balance = balance
                }; 
            if(choice=="1")
            {
                Console.WriteLine("Enter the amount to be deposit");
                decimal amount=Convert.ToDecimal(Console.ReadLine());
                
                decimal dep_bal=account.Deposit(amount);
                Console.WriteLine("Balance amount is "+dep_bal);
            }
            else if(choice =="2")
            {
                Console.WriteLine("Enter the amount to withdraw:");
                decimal withAmount= Convert.ToDecimal(Console.ReadLine());

                 decimal with_bal= account.Withdraw(withAmount);
                Console.WriteLine("Balance amount is "+with_bal); 
            }

        }
    }
}
/*
deposit amount is positive
 withdrawal amount is both positive and 
                  less than the available balance.
*/