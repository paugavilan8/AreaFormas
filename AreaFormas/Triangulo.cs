using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    public class Triangulo : Poligono
    {
        public double Base { get; private set; }
        public double Altura { get; private set; }

        public Triangulo(double bas, double alt) : base("Triángulo")
        {
            if (bas <= 0 || alt <= 0) throw new ArgumentException("Base y altura deben ser positivas.");
            Base = bas;
            Altura = alt;
        }

        public override double CalcularArea()
        {
            return 0.5 * Base * Altura;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} (b={1}, h={2})", Nombre, Base, Altura);
        }
    }
}
