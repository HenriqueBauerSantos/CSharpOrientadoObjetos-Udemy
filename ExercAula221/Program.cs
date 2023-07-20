using ExercAula221.Entities;

namespace ExercAula221 {
    class Program {
        static void Main(string[] args) {
            try {

                HashSet<Student> students = new HashSet<Student>();
                List<Student> a = new List<Student>();
                List<Student> b = new List<Student>();
                List<Student> c = new List<Student>();

                Console.Write("How many students for course A? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++) {
                    Console.Write($"{i+1}: ");
                    int std = int.Parse(Console.ReadLine());
                    a.Add(new Student(std));
                }

                Console.Write("How many students for course B? ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++) {
                    Console.Write($"{i + 1}: ");
                    int std = int.Parse(Console.ReadLine());
                    b.Add(new Student(std));
                }

                Console.Write("How many students for course C? ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++) {
                    Console.Write($"{i + 1}: ");
                    int std = int.Parse(Console.ReadLine());
                    c.Add(new Student(std));
                }

                foreach (var item in a) {
                    students.Add(item);
                }

                foreach (var item in b) {
                    students.Add(item);
                }

                foreach (var item in c) {
                    students.Add(item);
                }

                Console.WriteLine("Total students: " + students.Count);

            }

            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}