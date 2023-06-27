using ExercAula145.Entities.Enums;

namespace ExercAula145.Entities
{
    class Circle : Shape
    {
        public double Radius { get; protected set; }
        
        public Circle() 
        {
        }

        public Circle(Color color,double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14159*(Radius*Radius);
        }
    }
}
