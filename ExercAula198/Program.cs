namespace ExercAula198
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Área de trabalho\Estudos\ProjetosTI\file1.txt";
            string targetPath = @"D:\Área de trabalho\Estudos\ProjetosTI\file2.txt";

            try
            {
                string[]  lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string item in lines)
                    {
                        sw.WriteLine(item.ToUpper());
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
