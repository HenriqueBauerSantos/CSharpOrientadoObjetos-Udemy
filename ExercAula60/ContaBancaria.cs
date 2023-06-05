
using System.Globalization;

namespace ExercAula60 {
    internal class ContaBancaria {
        public string Nome { get; private set; }
        public int NumeroConta { get; private set; }
        public double Valor { get; private set; }

        public ContaBancaria() { }
        public ContaBancaria(string nome, int numeroConta) {
            Nome = nome;
            NumeroConta = numeroConta;
        }
        
        public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome,numeroConta) { 
            Deposito(depositoInicial); 
        }

        public void Deposito(double val) {
            Valor += val;
        }

        public void Saque(double val) {
            Valor -= (val + 5);
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Valor.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
