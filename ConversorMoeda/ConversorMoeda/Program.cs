using System;
using System.Globalization;

namespace ConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar atual: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite quantos doláres deseja comprar: ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double convert = ConversorDeMoeda.ConverterParaReal(cotacao, qtdDolar);

            Console.WriteLine("Valor a ser pago em reais: " + convert.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
