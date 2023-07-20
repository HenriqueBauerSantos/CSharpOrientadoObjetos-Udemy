namespace ExercAula226 {
    class Program
    {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2023, 07, 18, 7, 45, 23);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
