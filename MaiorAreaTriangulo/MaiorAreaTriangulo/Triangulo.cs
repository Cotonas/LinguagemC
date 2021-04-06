using System;
using System.Collections.Generic;
using System.Text;

namespace MaiorAreaTriangulo
{
    class Triangulo
    {
        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
