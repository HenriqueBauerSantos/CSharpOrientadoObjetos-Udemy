using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01 {
    internal class Product {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque() {
            double x = Quantidade * Preco;
            return x;
        }
        public void AdicionarProdutos(int q) {
            Quantidade = Quantidade + q;
        }
        public void RemoverProdutos(int q) {
            Quantidade= Quantidade - q;
        }
        public override string ToString() {
            return Nome + ", $ "+ Preco.ToString("F2",CultureInfo.InvariantCulture)
                +", "+ Quantidade+ " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
