using System;
using System.Collections.Generic;

namespace MySuperBank
{

    class Program
    {

        public static void Main(string[] args)
        {
            var account = new BankAccount("Tisha", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with initial balance ${account.Balance}.");

            account.MakeWithdrawl(700, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Pay back");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());


            //// Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            //// Test for a negative balance.
            try
            {
                account.MakeWithdrawl(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());

            }
        }
    }
}
