using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    public class Rectangulo : Poligono
    {
        public double Base { get; private set; }
        public double Altura { get; private set; }

        public Rectangulo(double bas, double alt) : base("Rectángulo")
        {
            if (bas <= 0 || alt <= 0) throw new ArgumentException("Base y altura deben ser positivas.");
            Base = bas;
            Altura = alt;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} (b={1}, h={2})", Nombre, Base, Altura);
        }
    }
}
