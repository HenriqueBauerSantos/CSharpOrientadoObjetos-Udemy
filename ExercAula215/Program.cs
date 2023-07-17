using ExercAula215.Entities;
using ExercAula215.Services;
using System.Globalization;

namespace ExercAula215 {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                Product proc = new Product(name, price);
                list.Add(proc);
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}