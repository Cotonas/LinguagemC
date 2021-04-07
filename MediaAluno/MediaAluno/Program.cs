using System;
using System.Globalization;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoMediaAnual aluno = new AlunoMediaAnual();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("NOTA FINAL = " + aluno.Media().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovacao())
            {
                Console.WriteLine("\nAPROVADO");
            }
            else
            {
                Console.WriteLine("\nREPROVADO");
                Console.WriteLine("FALTARAM "
                    + aluno.FaltouPouco().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS ");
            }
        }
    }
}
