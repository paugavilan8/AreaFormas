using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    public class Cuadrado : Poligono
    {
        public int NumeroLados { get; private set; }
        public double LongitudLado { get; private set; }

        public Cuadrado(int n, double L) : base("Polígono regular")
        {
            if (n < 3) throw new ArgumentException("Un polígono regular debe tener al menos 3 lados.");
            if (L <= 0) throw new ArgumentException("La longitud de lado debe ser positiva.");
            NumeroLados = n;
            LongitudLado = L;
        }

        public override double CalcularArea()
        {
            double n = NumeroLados;
            double L = LongitudLado;
            return (n * L * L) / (4.0 * Math.Tan(Math.PI / n));
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} (n={1}, L={2})", Nombre, NumeroLados, LongitudLado);
        }
    }
}
