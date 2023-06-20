using ExercAula142.Entities;
using System.Globalization;

namespace ExercAula142
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product {(i + 1)} data: ");
                Console.Write($"Commun, used or imported (c/u/i)? ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (type == "u" || type == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateOnly date = DateOnly.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(name, price, date);
                    products.Add(usedProduct);
                }
                else if (type == "i" || type == "I")
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProduct importedProduct = new ImportedProduct(name, price, fee);
                    products.Add(importedProduct);
                }
                else
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                Console.WriteLine("  ");
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (var item in products)
            {
                Console.WriteLine(item.PriceTag());
            }

        }
    }
}