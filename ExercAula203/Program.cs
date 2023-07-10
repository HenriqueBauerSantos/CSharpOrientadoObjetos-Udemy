using ExercAula203.Entities;
using ExercAula203.Services;
using System.Globalization;

namespace ExercAula203 {
    class Program
    {
        static void Main(string[] argrs) {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental rental = new CarRental(start, finish, new Vehicle(model));
            RentalService service = new RentalService(priceHour, priceDay, new BrazilTaxService());

            service.ProcessInvoice(rental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rental.Invoice);

        }
    }
}