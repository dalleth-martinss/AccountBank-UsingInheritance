


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



    }
}

