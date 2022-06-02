namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public double Lado1 {get; set;}

        private double Lado2 {get ;set ;}

        public override double CalcularPerimetro()
        {
            return Lado1 * 2 + Lado2 * 2;
        }

        public override double CalcularSuperficie()
        {
            return Lado1 * Lado2;
        }
    }
}