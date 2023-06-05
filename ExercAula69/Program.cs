using System.Globalization;

namespace ExercAula69 {
    class Program {
        static void Main(string[] args) {
            //Obtendo o numero de pessoas:
            Console.WriteLine("Digite o numero de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            double alturaMedia=0;

            //obtendo as alturas:
            for (int i = 0; i < n; i++) {
                Console.WriteLine(" ");
                Console.WriteLine("Digite a altura da "+(i+1)+" pessoa:");
                alturas[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                alturaMedia += alturas[i];
            }

            alturaMedia = alturaMedia/n;
            Console.WriteLine("A altura media das pessoas e: " + alturaMedia.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}