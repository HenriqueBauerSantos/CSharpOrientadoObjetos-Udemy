using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios010203 {
    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            double area = Largura * Altura;
            return area;
        }
        public double Perimetro() {
            double perimetro = (Largura*2)+(Altura*2);
            return perimetro;
        }
        public double Diagonal() {
            double diagonal = (Largura * Largura) + (Altura * Altura);
            diagonal = Math.Sqrt(diagonal);
            return diagonal;
        }
    }
}
