using ExercAula140.Entities;
using System.Globalization;

namespace ExercAula140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> List= new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee {(i+1)} data:");
                Console.Write("Outsourced (y/n)? ");
                string op = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                if (op == "y" || op == "Y")
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee emp = new OutSourceEmployee(name,hours,valHour,addCharge);
                    List.Add(emp);
                }
                else
                {
                    Employee emp = new Employee(name, hours,valHour);
                    List.Add(emp);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (var item in List)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}