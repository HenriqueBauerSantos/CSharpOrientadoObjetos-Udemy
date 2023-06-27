
namespace ExercAula146.Entities
{
    internal class CompanyPerson : Person
    {
        public int NumberOfEmployees { get; protected set; }

        public CompanyPerson() : base()
        {
        }

        public CompanyPerson(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0;
            if (NumberOfEmployees > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            else
                tax = AnnualIncome * 0.16;

            return tax;
        }
    }
}
