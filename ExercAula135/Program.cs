using ExercAula135.Entities;

namespace ExercAula135
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BuisinessAcount bacc = new BuisinessAcount(1002, "Maria", 0.0, 500);

            // Upcasting

            Account acc1 = bacc;
            Account acc2 = new BuisinessAcount(1003,"Bob", 0.0,200.0);
            Account acc3 = new SavingsAccount(1004,"Ana",0.0,0.01);

            //Downcasting

            BuisinessAcount acc4 = (BuisinessAcount)acc2;
            acc4.Loan(100);

            //BuisinessAcount acc5 = (BuisinessAcount)acc3;

            if (acc3 is BuisinessAcount)
            {
                BuisinessAcount acc5 = (BuisinessAcount)acc3;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Console.WriteLine(" --- ");
            //Exercicio de Virtual e Override

            Account acc10 = new Account(1010, "Alex", 500.0);
            Account acc11 = new SavingsAccount(1011, "Ana", 500.0, 0.01);

            acc10.Withdraw(10.0);
            acc11.Withdraw(10.0);

            Console.WriteLine(acc10.Balance);
            Console.WriteLine(acc11.Balance);
        }
    }
}