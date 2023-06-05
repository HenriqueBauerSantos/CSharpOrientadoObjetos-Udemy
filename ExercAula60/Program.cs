using System.Globalization;

namespace ExercAula60 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            string op = Console.ReadLine();
            double dep;
            if (op == "S" || op == "s") {
                Console.Write("Entre com o valor de deposito inicial: ");
                dep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            else {
                dep = 0;
            }

            ContaBancaria conta = new ContaBancaria(nome,numConta,dep);
            Console.WriteLine(" ");

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine(" ");

            Console.Write("Entre com um valor para deposito: ");
            conta.Deposito(dep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine(" ");

            Console.Write("Entre com um valor para saque: ");
            conta.Saque(dep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine(" ");

        }
    }
}
