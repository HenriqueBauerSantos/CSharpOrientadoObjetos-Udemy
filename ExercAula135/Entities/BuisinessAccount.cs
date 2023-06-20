
namespace ExercAula135.Entities
{
    class BuisinessAcount : Account
    {
        public double LoanLimet { get; set; }

        public BuisinessAcount() 
        {
        }

        public BuisinessAcount(int number, string holder, double balance, double loanLimit) : base(number,holder,balance)
        {
            LoanLimet = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimet)
            {
                Balance += amount;
            }
        }
    }
}
