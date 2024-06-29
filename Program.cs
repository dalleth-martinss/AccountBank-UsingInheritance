using System;
using ExerciseAccountBankUsandoHeranca.Entities;

namespace ExerciseAccountBankUsandoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(123, "John Doe", 1000.00, 1500.00);

            Console.WriteLine(account);


            account.Deposit(1000);
            account.withdraw(158.50);
            account.Loan(150.0);


            Console.WriteLine(account.Balance);

            Console.WriteLine(account.LoanLimit);



            Console.ReadLine();
        }
    }
}
