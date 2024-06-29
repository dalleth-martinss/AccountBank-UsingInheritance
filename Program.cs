using System;
using ExerciseAccountBankUsandoHeranca.Entities;

namespace ExerciseAccountBankUsandoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(123, "John Doe", 1000.0, 500.0);

            Console.WriteLine(account.Number);
            Console.WriteLine(account.Holder);
            Console.WriteLine(account.Balance);

            account.Deposit(1000);
            account.withdraw(158.50);

            account.LoanLimit = 5000.00;
            account.Loan(6000.00);

            
            
            

            Console.WriteLine(account.Balance);
            Console.WriteLine(account.LoanLimit);

            Console.ReadLine();
        }
    }
}
