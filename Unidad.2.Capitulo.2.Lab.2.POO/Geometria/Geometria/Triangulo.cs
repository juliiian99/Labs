using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo : Poligono
    {
        private double Lado1 { get; set; }
        private double Lado2 { get; set; }
        private double Lado3 { get; set; }
        private double B { get; set; }
        private double H { get; set; }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public override double CalcularSuperficie()
        {
            return B * H / 2;
        }
    }
}