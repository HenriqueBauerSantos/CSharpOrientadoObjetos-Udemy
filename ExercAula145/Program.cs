using ExercAula145.Entities;
using ExercAula145.Entities.Enums;
using System.Globalization;

namespace ExercAula145
{
    class program
    {
        static void Main(string[] args)
        {
            //Determinação da lista e numero de dados a ser obtidos:
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            //Obter os dados:
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape {(i+1)} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                
                if (op == 'r' || op == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Shape shape = new Rectangle(color, width, height);
                    shapes.Add(shape);
                }
                else if (op == 'c' || op == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    Shape shape = new Circle(color, radius);
                    shapes.Add(shape);
                }
                else
                {
                    Console.WriteLine("Opcao invalida. ");
                }
            }

            //Mostrar areas:
            Console.WriteLine("SHAPE AREAS: ");
            foreach (var item in shapes)
            {
                Console.WriteLine(item.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}