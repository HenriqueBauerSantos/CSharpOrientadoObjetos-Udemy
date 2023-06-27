using System.Globalization;

namespace ExercAula146.Entities
{
    abstract public class Person
    {
        public string Name { get; protected set; }
        public double AnnualIncome { get; protected set; }

        protected Person() 
        {
        }

        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Name
                +": $ "
                +Tax().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
