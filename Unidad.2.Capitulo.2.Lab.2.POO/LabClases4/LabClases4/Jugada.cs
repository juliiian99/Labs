using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabClases4
{
    public class Jugada
    {
        protected bool _adivino;
        protected int _intentos;
        protected int _numero;

        public bool Adivino { get { return _adivino; } set { _adivino = value; } }

        public int Intentos { get { return _intentos; } set { _intentos = value; } }

        public int Numero { get { return _numero; } set { _numero = value; } }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public virtual bool Comparar(int numero)
        {
            Intentos += 1;
            Console.WriteLine("Salio el numero: " + Numero);
            if (numero == Numero)
            {
                Adivino = true;
                Console.WriteLine("Adivinaste!");
            }
            else
            {
                Adivino = false;
                Console.WriteLine("Casi!");
            }
            return Adivino;
        }
    }
}