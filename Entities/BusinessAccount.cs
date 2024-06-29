


using System;
using System.Text;

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
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            // verificar se o valor do emprestimo é < ou = ao LoanLimit(limite de emprestimo) e p valor do emprestimo cai na conta balance 
            if( amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("O valor do empréstimo excede o limite permitido.");
            }

        }

        public override string ToString()
        {
            //  StringBuilder para formatar o output 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()); // Chama o método ToString() da classe base (Account)
            sb.AppendLine($"Limite de empréstimo: {LoanLimit:C}"); // Adicione o limite de empréstimo

            return sb.ToString();
        }



    }
}

