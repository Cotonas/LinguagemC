using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {
            DadosConta conta;

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S') {
                Console.Write("Digite o valor a ser depositado: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new DadosConta(numeroConta, titular, depositoInicial);
            }
            else {
                conta = new DadosConta(numeroConta, titular);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nDigite um valor para depósito: ");
            double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantidade);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nDigite o valor para saque: ");
            quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(quantidade);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
