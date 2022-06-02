using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabClases4
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        public override bool Comparar(int numero)
        {
            Intentos += 1;
            //Console.WriteLine("Salio el numero: " + Numero);
            if (numero == Numero)
            {
                Adivino = true;
                Console.WriteLine("Adivinaste!");
            }
            else
            {
                Adivino = false;
                if ( Math.Abs(numero - Numero) < 5)
                {
                    Console.WriteLine("Casi!");
                }
                else
                {
                    Console.WriteLine("Muy lejos");
                }
            }
            return Adivino;
        }
    }
}