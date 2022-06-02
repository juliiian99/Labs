using System;
using System.Collections.Generic;

namespace Geometria
{
    public class Circulo : Poligono
    {
        private const double PI = 3.141592;

        private double Radio{ get; set; }

        public override double CalcularPerimetro()
        {
            return 2 * Radio * PI;
        }

        public override double CalcularSuperficie()
        {
            return PI * Math.Pow(Radio, 2);

        }
    }
}
