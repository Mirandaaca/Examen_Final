using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    public class Rectangulo : clsFiguraGeometrica, Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(string nombre, double baseRectangulo, double alturaRectangulo) : base (nombre)
        {
            Base = baseRectangulo;
            Altura = alturaRectangulo;
        }

        public double area(double valor1, double valor2)
        {
            return Base * Altura;
        }

        public override string ToString()
        {
            return $"{nombre}  Área  = {area(Base, Altura)}";
        }
    }
}
