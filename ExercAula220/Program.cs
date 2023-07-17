using ExercAula220.Entitie;

namespace ExercAula220 {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRegister> list = new HashSet<LogRegister>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        string[] div = line.Split(' ');
                        string name = div[0];
                        DateTime instant = DateTime.Parse(div[1]);
                        list.Add(new LogRegister(name, instant));
                    }
                    Console.WriteLine("Total user: " + list.Count);
                }
            }

            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
