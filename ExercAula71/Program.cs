namespace ExercAula71 {
    class Program {
        static void Main(string[] args) {
            //Instanciar os vetor com os 10 quartos e solicitar quantos seram alugados:
            AluguelQuartos[] quartos = new AluguelQuartos[10];
            Console.WriteLine("Quantos quartos seram alugados?");
            int n = int.Parse(Console.ReadLine());

            //Reserver os quartos:
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Reserva " + (i + 1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("  ");
                quartos[(quarto-1)] = new AluguelQuartos(nome, email);
            }

            //Mostrando os quartos alugados:
            Console.WriteLine("Quartos alugados: ");
            for (int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine((i+1)+": "+ quartos[i]);
                }
            }
        }
    }

}
