using System.Globalization;
using System;

namespace MaiorAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();


            Console.WriteLine("Área de X = " + x.Area().ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + y.Area().ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área é do triângulo: X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Maior área é do triângulo: Y");
            }
            else
            {
                Console.WriteLine("Os triângulos X e Y possuem a mesma área.");
            }



        }
    }
}
