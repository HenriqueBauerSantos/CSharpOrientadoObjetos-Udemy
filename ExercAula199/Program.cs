using System.Collections.Generic;

namespace ExercAula199
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Área de trabalho\Estudos\ProjetosTI\pastaTeste";

            try
            {
                var folgers = Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string item in folgers)
                {
                    Console.WriteLine(item);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }

            catch (IOException e) 
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}