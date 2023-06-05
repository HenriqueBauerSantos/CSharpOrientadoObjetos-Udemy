using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercAula78 {
    internal class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double sal) {
            Id = id;
            Nome = nome;
            Salario = sal;
        }
        public void AumentarSalario(double por) {
            Salario *= (1+(por/100));
        }

        public override string ToString() {
            return Id+", "
                +Nome
                +", "
                +Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
