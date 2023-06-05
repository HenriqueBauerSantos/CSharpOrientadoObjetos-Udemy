using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercAula70 {
    internal class Produto {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public Produto(string nome, double valor) {
            Nome = nome;
            Preco = valor;
        }
    }
}
