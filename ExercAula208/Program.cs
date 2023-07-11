using ExercAula208.Entities;
using ExercAula208.Services;
using System.Globalization;

namespace ExercAula208 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter contract data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy):");
                DateOnly date = DateOnly.Parse(Console.ReadLine());
                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int installmentsNumber = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number, date, value);
                ContractProcess process = new ContractProcess(new PaypalService());
                process.PaymentsGenerating(contract, installmentsNumber);

                Console.WriteLine("Installments: ");
                foreach (var contr in contract.Installments)
                {
                    Console.WriteLine(contr);
                }
            }

            catch (IOException ex) {
                Console.WriteLine("Error: ");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) {
                Console.WriteLine("Error: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}