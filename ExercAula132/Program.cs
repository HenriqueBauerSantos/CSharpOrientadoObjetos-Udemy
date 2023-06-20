using ExercAula132.Entities;
using ExercAula132.Entities.Enums;

namespace ExercAula132
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Client client = new Client();
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            
            Console.Write("Birth date (DD/MM/YYYY): ");
            client.BirthDate = DateOnly.Parse(Console.ReadLine());
            
            order.Client = client;

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered ): ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int qtn = int.Parse(Console.ReadLine());
            for (int i = 0; i< qtn; i++)
            {                
                Product product = new Product();

                Console.WriteLine($"Enter {(i+1)} item data: ");
                Console.Write("Product name: ");
                product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                product.Price = price;
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(quantity,price,product);
                order.Orders.Add(item);
            }

            Console.WriteLine(order);
        }
    }
}