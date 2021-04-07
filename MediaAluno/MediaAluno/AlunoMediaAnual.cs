using System;
using System.Globalization;

namespace MediaAluno
{
    class AlunoMediaAnual
    {
        public double N1, N2, N3;
        public string Nome;

        public double Media()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovacao()
        {
            if (Media() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FaltouPouco()
        {
            if (Aprovacao())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Media();
            }
        }
    }
}
