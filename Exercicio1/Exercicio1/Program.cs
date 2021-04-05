using System;

namespace Exercicio1
{
    class Program
    {
        //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.Write("Pessoa mais velha " + p1.Nome);
            }
            else if (p1.Idade < p2.Idade)
            {
                Console.Write("Pessoa mais velha " + p2.Nome);
            }
            else
            {
                Console.Write("As duas possuem a mesma idade.");
            }

        }
    }
}
