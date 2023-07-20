using System.Collections.Generic;

namespace ExercAula223 {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, int> votos = new Dictionary<string, int>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {                        
                        string[] div = sr.ReadLine().Split(',');
                        string name = div[0];
                        int num = int.Parse(div[1]);

                        if (votos.ContainsKey(name)) {
                            votos[name] += num;
                        }
                        else {
                            votos[name] = num;
                        }
                    }

                    foreach (var item in votos)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    };
                }

            }


            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}