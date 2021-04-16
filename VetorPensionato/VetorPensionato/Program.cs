using System;
using System.Globalization;

namespace VetorPensionato {
    class Program {
        static void Main(string[] args) {

            //Na correção esta Estudante[10], porém caso algum aluno escolha o quarto 10 o projeto dará um erro,
            //Sendo assim preferi criar um vetor com 12 espaços de mémoria, caso escolha o quarto 1 ou o 10 não dará problemas.
            Estudante[] vect = new Estudante[11];

            Console.Write("Digite a quantidade de alunos para hospedagem: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("\nRent: #" + i + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Estudante(name, email);
            }

            Console.WriteLine("\nBusy: ");
            for (int i = 1; i <= 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
