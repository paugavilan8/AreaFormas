using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormas
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("--- MENÚ FIGURAS ---");
                Console.WriteLine("1) Crear Círculo y mostrar área");
                Console.WriteLine("2) Crear Elipse y mostrar área");
                Console.WriteLine("3) Crear Rectángulo y mostrar área");
                Console.WriteLine("4) Crear Triángulo y mostrar área");
                Console.WriteLine("5) Crear Polígono Regular y mostrar área");
                Console.WriteLine("6) Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();
                try
                {
                    if (opcion == "1")
                    {
                        MostrarArea(CrearCirculo());
                    }
                    else if (opcion == "2")
                    {
                        MostrarArea(CrearElipse());
                    }
                    else if (opcion == "3")
                    {
                        MostrarArea(CrearRectangulo());
                    }
                    else if (opcion == "4")
                    {
                        MostrarArea(CrearTriangulo());
                    }
                    else if (opcion == "5")
                    {
                        MostrarArea(CrearCuadrado());
                    }
                    else if (opcion == "6")
                    {
                        Console.WriteLine("Hasta luego.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void MostrarArea(Forma forma)
        {
            double area = forma.CalcularArea();
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0} => Área = {1}", forma, area));
        }

        static Circulo CrearCirculo()
        {
            double r = LeerDoublePositivo("Ingresa el radio: ");
            return new Circulo(r);
        }

        static Elipse CrearElipse()
        {
            double a = LeerDoublePositivo("Ingresa el semieje a: ");
            double b = LeerDoublePositivo("Ingresa el semieje b: ");
            return new Elipse(a, b);
        }

        static Rectangulo CrearRectangulo()
        {
            double b = LeerDoublePositivo("Ingresa la base: ");
            double h = LeerDoublePositivo("Ingresa la altura: ");
            return new Rectangulo(b, h);
        }

        static Triangulo CrearTriangulo()
        {
            double b = LeerDoublePositivo("Ingresa la base: ");
            double h = LeerDoublePositivo("Ingresa la altura: ");
            return new Triangulo(b, h);
        }

        static Cuadrado CrearCuadrado()
        {
            int n = LeerEnteroMinimo("Ingresa el número de lados (>=3): ", 3);
            double L = LeerDoublePositivo("Ingresa la longitud del lado: ");
            return new Cuadrado(n, L);
        }

        static double LeerDoublePositivo(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                double v;
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out v) && v > 0)
                    return v;
                Console.WriteLine("Valor inválido. Usa punto para decimales y un número > 0.");
            }
        }

        static int LeerEnteroMinimo(string prompt, int minimo)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                int v;
                if (int.TryParse(s, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out v) && v >= minimo)
                    return v;
                Console.WriteLine("Valor inválido. Debe ser un entero >= " + minimo + ".");
            }
        }
    }
}
