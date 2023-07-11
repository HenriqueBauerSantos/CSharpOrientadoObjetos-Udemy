using System.Globalization;

namespace ExercAula208.Entities {
    class Installment {
        public DateOnly DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateOnly dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
