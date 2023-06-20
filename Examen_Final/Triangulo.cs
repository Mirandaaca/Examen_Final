using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    public class Triangulo : clsFiguraGeometrica, Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(string nombre, double baseTriangulo, double alturaTriangulo) : base(nombre)
        {
            this.Base = baseTriangulo;
            this.Altura = alturaTriangulo;
        }

        public double area(double valor1, double valor2)
        {
            return (Base * Altura) / 2;
        }

        public override string ToString()
        {
            return $"{nombre}  Área  = {area(Base, Altura)}";
        }
    }
}
