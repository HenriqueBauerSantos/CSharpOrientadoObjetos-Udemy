using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios010203 {
    internal class Aluno {
        public string Nome;
        public double Nota1Semestre;
        public double Nota2Semestre;
        public double Nota3Semestre;
        public double NotaFinal;

        public double NotaFinalSemestre() {
            double nota = ((Nota1Semestre * 3) + (Nota2Semestre * 3.5) + (Nota3Semestre * 3.5)) / 10;
            return nota;
        }
        public Boolean AprovacaoAluno() {
            double nota = NotaFinalSemestre();
            if (nota >= 60) {
                return true;
            }
            else
                return false;
        }
        public override String ToString() {
            return "Aluno " + Nome + ", media final de " + NotaFinalSemestre().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
