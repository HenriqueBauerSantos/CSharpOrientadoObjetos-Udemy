
using ExercAula155.Entities.Exceptions;

namespace ExercAula155.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: The amount exceeds the acoount balance.");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds account withdraw limit.");
            }

            Balance -= amount;
        }
    }
}
