using System;
using System.Collections.Generic;
using System.Text;


namespace ExerciseAccountBankUsandoHeranca.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;

        }

        public void withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // Método para obter uma representação de string da conta
        public override string ToString()
        {
            // Use o StringBuilder para construir a string
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Número da conta: {Number}");
            sb.AppendLine($"Titular da conta: {Holder}");
            sb.AppendLine($"Saldo atual: {Balance:C}"); // Formata o saldo como moeda

            return sb.ToString(); // Retorna a string construída
        }


    }
}
