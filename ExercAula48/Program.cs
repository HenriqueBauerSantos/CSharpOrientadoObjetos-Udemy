
using System.Globalization;

namespace ExercAula48 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual e a cotacao do dolar?");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolarares voce vai comprar?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorPagar = ConversorDeMoeda.ConversorMoeda(cotacao,valor);
            Console.WriteLine("Valor a ser pago em reais: "+ valorPagar.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
