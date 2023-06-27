using ExercAula146.Entities;
using System.Globalization;

namespace ExercAula146
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a lista de possoas e ubtendo o numero a ser salvo:
            List<Person> people = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            //Obtendo os dados de cada pessoa e salvendo na lista:
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer {(i+1)} data: ");

                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'i' || op == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Person person = new IndividualPerson(name,anualIncome,healthExp);
                    people.Add(person);
                }
                else if (op == 'c' || op == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine()); 
                    Person person = new CompanyPerson(name,anualIncome,numberEmployees);
                    people.Add(person);
                }
                else
                {
                    Console.WriteLine("invalid option, Company (c) or Individual (i).");
                    i--;
                }
                Console.WriteLine("  ");
            }

            //Mostrar as taxas:
            Console.WriteLine("TAXES PAID: ");
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}