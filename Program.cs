using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("John Doe", 500.0);

            Console.WriteLine($"Account created with account number: {account.AccountNumber}");
            Console.WriteLine($"Account balance: {account.Balance}");

            account.Deposit(100.0);
            Console.WriteLine($"Amount deposited: {100.0}");
            Console.WriteLine($"Account balance: {account.Balance}");

            account.Withdraw(50.0);
            Console.WriteLine($"Amount withdrawn: {50.0}");
            Console.WriteLine($"Account balance: {account.Balance}");
            Console.ReadKey();
        }
    }

}
