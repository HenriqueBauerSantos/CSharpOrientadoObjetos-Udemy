namespace ExercAula222 {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("phone");
            if (cookies.ContainsKey("phone")) {
                Console.WriteLine(cookies["phone"]);
            }
            else {
                Console.WriteLine("There is no 'phone' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All cookies: ");
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
