namespace ExercAula80 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Quantidade de numeros de Linhas e Colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.WriteLine("Digite o elemento na posicao (" + i + "," + j + "):");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("   ");
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i]);
                Console.Write(" ");
            }

            Console.WriteLine("   ");
            int negNum = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        negNum++;
                    }
                }
            }
            Console.Write("Negative numbers = "+negNum);
        }
    }
}