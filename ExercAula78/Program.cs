using System.Globalization;

namespace ExercAula78 {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("How many employees will be registered? ");
            int many = int.Parse(Console.ReadLine());

            for (int i = 0; i < many; i++) {
                Console.WriteLine("    ");
                Console.WriteLine("Employoee " + (i + 1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, name, sal));

            }
            Console.WriteLine("    ");
            Console.Write("Enter the employee id that will have salary increase: ");
            int emploId = int.Parse(Console.ReadLine());

            Funcionario funcionarioAutomento = list.Find(x => x.Id == emploId);
            if (funcionarioAutomento != null) {
                Console.Write("Enter the porcentage: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarioAutomento.AumentarSalario(porcent);
            }
            else {
                Console.WriteLine("This id does not existe!");
            }

            Console.WriteLine("    ");
            Console.WriteLine("Updated list of employees: ");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}