


using System;

namespace ExerciseAccountBankUsandoHeranca.Entities
{
     class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
   

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            double LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            // verificar se o valor do emprestimo é < ou = ao LoanLimit(limite de emprestimo)
            if( amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Saldo de limite insuficiente.");
            }
        }

    }
}

