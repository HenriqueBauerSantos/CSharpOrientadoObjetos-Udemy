using System;
using System.Globalization;

namespace ProjetoCOrientadoObjetos {
    internal class Program {
        static void Main(string[] args) {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();
            double media;
            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite o seu salario: ");
            p1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite o seu salario: ");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = ((p1.salario + p2.salario) / 2);
            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: "+p1.nome);
            Console.WriteLine("Salario: "+p1.salario);
            Console.WriteLine("Dados do psegundo funcionario: ");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Salario: " + p2.salario);
            Console.WriteLine("Media salarioal: " + media);
        }
    }
}