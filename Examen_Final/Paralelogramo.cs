using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    public class Paralelogramo : clsFiguraGeometrica, Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Paralelogramo(string nombre, double baseParalelogramo, double alturaParalelogramo) :base(nombre)
        {
            this.Base = baseParalelogramo;
            this.Altura = alturaParalelogramo;
            this.nombre = nombre;
        }

        public double area(double valor1, double valor2)
        {
            return Base * Altura;
        }

        public override string ToString()
        {
            return $"{nombre} Área = {area(Base, Altura)}";
        }
    }
}
