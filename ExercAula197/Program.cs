namespace ExercAula197
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Área de trabalho\Estudos\ProjetosTI\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}