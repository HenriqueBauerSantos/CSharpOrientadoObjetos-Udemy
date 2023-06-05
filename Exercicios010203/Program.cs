using System.Globalization;

namespace Exercicios010203 {
    class Program {
        static void Main(string[] args) {
            int op = 1;
            while (op == 1 || op == 2 || op== 3) {
                Console.WriteLine("Exercicios:\n1- Classe Retangulo.\n2- Classe Funcionario.\n3- Classe Aluno.");
                Console.WriteLine("Escolha uma opcao: ");
                op = int.Parse(Console.ReadLine());

                //Execucao do primeiro exercicio
                if (op == 1) {
                    Retangulo x = new Retangulo();
                    Console.WriteLine("Entre a largura e altura do retangulo: ");
                    Console.Write("Altura: ");
                    x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("\nLargura: ");
                    x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Area: " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Perimetro: " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Diagonal: " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
                }

                //Execucao do segundo exercicio
                else if (op == 2) {
                    Funcionario fun01 = new Funcionario();
                    Console.WriteLine("Digite o nome do funcionario: ");
                    fun01.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o salario bruto do funcionario: ");
                    fun01.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Digite o valor do imposto: ");
                    fun01.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("-----");
                    Console.WriteLine("Funcionario: " + fun01);

                    Console.WriteLine("-----");
                    Console.WriteLine("Deseja aumentar o salario do funcionario em qual porcentagem? ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    fun01.SalarioBruto = fun01.AumentarSalario(porcentagem);

                    Console.WriteLine("-----");
                    Console.WriteLine("Dados atualizados: " + fun01);
                }

                //Execucao do terceiro exercicio
                else if (op == 3) {
                    Aluno aluno = new Aluno();  
                    // Obtendo os dados do aluno:
                    Console.WriteLine("Digite o nome do aluno: ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite a nota do primeiro trimestre: ");
                    aluno.Nota1Semestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Digite a nota do segundo trimestre: ");
                    aluno.Nota2Semestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Digite a nota do terceito trimestre: ");
                    aluno.Nota3Semestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double media = aluno.NotaFinalSemestre();
                    Boolean pass = aluno.AprovacaoAluno();

                    Console.WriteLine(aluno);
                    if (pass == false)
                    {
                        double falta = 60.0 - media;
                        Console.WriteLine("REPROVADO\nFALTARAM " + falta + "pontos");
                    }else
                        Console.WriteLine("APROVADO");
                }
            }
        }
    }
}
