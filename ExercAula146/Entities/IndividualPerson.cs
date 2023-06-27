using System;
using System.Collections.Generic;

namespace ExercAula146.Entities
{
    public class IndividualPerson : Person
    {
        public double HealthExpenditures { get; protected set; }

        public IndividualPerson() : base()
        {
        }

        public IndividualPerson(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            }
            else if (AnnualIncome >= 20000.00)
            {
                tax = AnnualIncome * 0.25;
            }
            return tax-(HealthExpenditures/2);
        }
    }
}
