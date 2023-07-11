using ExercAula208.Services;

namespace ExercAula208.Entities {
    class Contract {
        public int Number { get; private set; }
        public DateOnly Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; protected set; }

        public Contract(int number, DateOnly date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment) {
            Installments.Add(installment);
        }
    }
}
