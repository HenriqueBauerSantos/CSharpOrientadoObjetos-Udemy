using ExercAula145.Entities.Enums;

namespace ExercAula145.Entities
{
    abstract class Shape
    {
        public Color Color { get; protected set; }

        public Shape()
        {
        }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
