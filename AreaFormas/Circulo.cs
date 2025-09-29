using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    public class Circulo : Elipse
    {
        public double Radio { get { return SemiejeMayor; } }

        public Circulo(double radio) : base(radio, radio)
        {
            if (radio <= 0) throw new ArgumentException("El radio debe ser positivo.");
            // Nombre más descriptivo
            this.Nombre = "Círculo";
        }
    }
}
