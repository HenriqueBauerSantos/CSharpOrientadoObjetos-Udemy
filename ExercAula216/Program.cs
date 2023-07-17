using ExercAula216.Entities;

namespace ExercAula216 {
    class Program {
        static void Main(string[] args) {
            Client client1 = new Client {Name = "Maria", Email = "maria@gmail.com" };
            Client client2 = new Client { Name = "Alex", Email = "Alex@gmail.com" };

            Console.WriteLine(client1.Equals(client2));
            Console.WriteLine(client1 == client2);
            Console.WriteLine(client1.GetHashCode());
            Console.WriteLine(client2.GetHashCode());
        }
    }
}