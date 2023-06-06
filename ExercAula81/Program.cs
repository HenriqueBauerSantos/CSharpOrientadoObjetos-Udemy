namespace ExercAula81 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Write the number of matriz lines: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the number of matriz columns: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    Console.WriteLine("Write the number of positon (" + i + "," + j + "):");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("  ");
            Console.WriteLine("Write the number that be searsh: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("  ");
            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    if (mat[i, j] == num) {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (i != 0) {
                            Console.WriteLine("Up: " + mat[(i-1),j]);
                        }
                        if (i < mat.GetLength(0)) {
                            Console.WriteLine("Down: " + mat[(i + 1), j]);
                        }
                        if (j != 0) {
                            Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        }
                        if ((j+1) < mat.GetLength(1)) {
                            Console.WriteLine("Right: " + mat[i, (j + 1)]);
                        }
                    }
                }
            }
        }
    }
}