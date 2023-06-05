using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercAula48 {
    internal class ConversorDeMoeda {
        public static double ConversorMoeda(double cota, double valor) {
            double pagar = (cota*valor)*1.06;
            return pagar;
        }
    }
}
