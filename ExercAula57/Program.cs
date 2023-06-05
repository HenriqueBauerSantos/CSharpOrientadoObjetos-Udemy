namespace ExercAula57 {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 599.99, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4k";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
