using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorMoeda
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ConverterParaReal(double cotacao, double qtdDolar)
        {
            double total = cotacao * qtdDolar;
            return total + total * Iof / 100.0;
        }
    }
}
