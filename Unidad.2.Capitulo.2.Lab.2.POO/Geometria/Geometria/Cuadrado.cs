using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Poligono
    {
        private double Lado { get; set; }
        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }

        public override double CalcularSuperficie()
        {
            return Lado * Lado;
        }
    }
}
