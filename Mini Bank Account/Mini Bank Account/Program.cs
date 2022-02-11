using System;

namespace Mini_Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int accountNumber = generator.Next(0, int.MaxValue);

            Console.WriteLine("=========================");
            Console.WriteLine("CREATE BANK ACCOUNT");
            Console.WriteLine("=========================");
            Console.WriteLine("Enter account name: ");
            string accountName = Console.ReadLine();
            Console.WriteLine("Enter starting balance: ");
            decimal startingBalance = decimal.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(accountName, accountNumber, startingBalance);

            Console.WriteLine("What do you want to do:");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Exit");

            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("Enter the amount you want to withdraw: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                account.WithdrawFunds(amount);
                Console.WriteLine("Sucessfully withdrawn {0}", amount);
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Enter the amount you want to deposit: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                account.AddFunds(amount);
                Console.WriteLine("Sucessfully added funds of {0}", amount);
            }
            else 
            {
                Console.WriteLine("Exited: You have sucessfully exited the application");
            }

        }
    }
}
