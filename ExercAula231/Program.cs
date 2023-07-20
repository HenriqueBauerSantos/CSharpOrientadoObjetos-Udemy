using ExercAula231.Services;

namespace ExercAula231 {
    class Program {

        delegate void BinaryNumericOperation(double m1, double n2);

        static void Main(string[] args) {

            double a = 10, b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);


        }
    }
}