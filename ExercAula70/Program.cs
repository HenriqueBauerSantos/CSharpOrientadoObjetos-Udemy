using System.Globalization;

namespace ExercAula70 {
    class Program {
        static void Main(string[] args) {
            //Declarando os produtos
            Console.WriteLine("Quantos produtos a serem inseridos: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o nome do " + (i+1)+ " produto:");
                string nome= Console.ReadLine();
                Console.WriteLine("Digite o valor do " + (i + 1) + " produto:");
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                produtos[i]= new Produto(nome,valor);
            }

            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += produtos[i].Preco;
            }
            double med = sum/n;

            Console.WriteLine("A media dos valores dos produtos e: "+ med);
        }
    }

}