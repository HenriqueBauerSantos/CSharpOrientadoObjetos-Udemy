using ExercAula155.Entities;
using ExercAula155.Entities.Exceptions;
using System.Globalization;

namespace ExercAula155
{
    class Program
    {
        public static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double init = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, init, withdrawLimit);

                Console.WriteLine(" ");
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance.ToString("F2",  CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
