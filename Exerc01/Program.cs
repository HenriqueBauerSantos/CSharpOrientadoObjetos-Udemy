using System.Globalization;
namespace Exerc01 {
    class Program {
        static void Main(string[] args) {
            Product p = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade= int.Parse(Console.ReadLine());
            Console.WriteLine("Dados produto: "+p);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Adicionando: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados produto: " + p);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Remover: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados produto: " + p);
            Console.WriteLine("----------------------------------");
        }
    }
}