using ExercAula201.Entities;
using System.Globalization;

namespace ExercAula201 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o caminho do arquivo(cvs): ");
            string srFile = Console.ReadLine();

            try {
                string directory = Path.GetDirectoryName(srFile);
                string folderOut = directory + @"\out";
                string fileOut = folderOut + @"\summary.csv";

                Directory.CreateDirectory(folderOut);

                using (StreamWriter sw = File.AppendText(fileOut)) {
                    string[] lines = File.ReadAllLines(srFile);

                    foreach (string line in lines) {
                        string[] fields = line.Split(';');
                        string name = fields[0];
                        double value = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, value, quantity);

                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }

            catch (IOException e) {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}