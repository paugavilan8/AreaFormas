using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    public abstract class Forma
    {
        public string Nombre { get; protected set; }

        protected Forma(string nombre)
        {
            if (string.IsNullOrEmpty(nombre)) throw new ArgumentException("El nombre no puede ser vacío.");
            Nombre = nombre;
        }

        public abstract double CalcularArea();

        public override string ToString()
        {
            return Nombre;
        }
    }

}
