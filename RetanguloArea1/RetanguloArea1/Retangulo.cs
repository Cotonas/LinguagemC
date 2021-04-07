using System;
using System.Globalization;

namespace RetanguloArea1
{
    class Retangulo
    {
        public double Largura, Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }


        public override string ToString()
        {
            return "ÁREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPEÍMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
