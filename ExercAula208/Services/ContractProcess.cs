using ExercAula208.Entities;

namespace ExercAula208.Services {
    class ContractProcess {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractProcess(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void PaymentsGenerating(Contract contract, int numberOfPayment) {
            double basicAmount = contract.TotalValue / numberOfPayment;
            
            for (int i = 0; i < numberOfPayment; i++) {
                DateOnly date = contract.Date.AddMonths(i + 1);
                double amountUpDate = basicAmount + _onlinePaymentService.Interest(basicAmount, (i + 1));
                double amountToPay = amountUpDate + _onlinePaymentService.PaymentFee(amountUpDate);
                contract.Installments.Add(new Installment (date,amountToPay));
            }
        }
    }
}
