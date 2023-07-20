using ExercAula233.Services;
using System.Collections.Generic;

namespace ExercAula233 {
    class Program
    {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("Hd Case", 89.90));

            Action<Product> act = UpdatePrice;

            list.ForEach(act);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UpdatePrice(Product product) {
            product.Price += product.Price * 0.1;
        }
    }
}