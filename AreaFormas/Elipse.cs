using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    public class Elipse : Forma
    {
        public double SemiejeMayor { get; private set; }
        public double SemiejeMenor { get; private set; }

        public Elipse(double a, double b) : base("Elipse")
        {
            if (a <= 0 || b <= 0) throw new ArgumentException("Los semiejes deben ser positivos.");
            if (a >= b)
            {
                SemiejeMayor = a;
                SemiejeMenor = b;
            }
            else
            {
                SemiejeMayor = b;
                SemiejeMenor = a;
            }
        }

        public override double CalcularArea()
        {
            return Math.PI * SemiejeMayor * SemiejeMenor;
        }

        public override string ToString()
        {
            bool esCirculo = Math.Abs(SemiejeMayor - SemiejeMenor) < 1e-12;
            return esCirculo
                ? string.Format(CultureInfo.InvariantCulture, "Círculo (r={0})", SemiejeMayor)
                : string.Format(CultureInfo.InvariantCulture, "Elipse (a={0}, b={1})", SemiejeMayor, SemiejeMenor);
        }
    }
}
