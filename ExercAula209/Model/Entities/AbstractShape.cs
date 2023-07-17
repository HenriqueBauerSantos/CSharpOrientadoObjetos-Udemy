using ExercAula209.Model.Enums;

namespace ExercAula209.Model.Entities {
    abstract class AbstractShape : IShape{

        public Color Color { get; set; }

        public abstract double Area();
        
    }
}
