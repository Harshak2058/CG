using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTrans_Exception
{
    public class Account
    {
        public string AccountNumber{get;set;}
        public decimal Balance{get;set;}

        public decimal Deposit(decimal amount)
        {
            try
            {
            if(amount>0)
            {
                Balance= amount+Balance;
                return Balance;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            return Balance;

        }
        public decimal Withdraw(decimal amount)
        {
            try{
                if(amount<=0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive");

                }
                else if(amount>Balance)
                {
                    throw new InvalidOperationException("Insufficient funds");

                }
                else{
                    Balance= Balance- amount;
                    return Balance;
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Balance;
        }
    }
}