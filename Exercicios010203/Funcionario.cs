using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios010203 {
    internal class Funcionario {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            double liquido = SalarioBruto - Imposto;
            return liquido;
        }
        public double AumentarSalario(double porcent) {
            double novoSal = SalarioBruto*(1+(0.01*porcent));
            return novoSal;
        }
        public override String ToString() {
            return Nome+", R$ "+SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
