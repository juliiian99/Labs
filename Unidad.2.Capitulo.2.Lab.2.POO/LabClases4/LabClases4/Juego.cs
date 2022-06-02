using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabClases4
{
    public class Juego
    {
        private int _record;

        public Juego() { _record = 999999999; }

        public int Record { get { return _record; } set { _record = value; } }

        public void ComenzarJuego()
        {
            Console.WriteLine("Con ayuda o sin? con/sin");
            string ayuda = Console.ReadLine();
            if (ayuda.Equals("sin"))
            {
                Jugada jugada = new Jugada(this.PreguntarMaximo()) { Intentos = 0 };
                do
                {
                    jugada.Comparar(this.PreguntarNumero());
                } while (this.Continuar() && !jugada.Adivino);
                this.CompararRecord(jugada);
            }
            else
            {
                JugadaConAyuda jugada = new JugadaConAyuda(this.PreguntarMaximo()) { Intentos = 0 };
                do
                {
                    jugada.Comparar(this.PreguntarNumero());
                } while (this.Continuar() && !jugada.Adivino);
                this.CompararRecord(jugada);
            }

        }

        private void CompararRecord(Jugada jugada)
        {
            if(_record > jugada.Intentos && jugada.Adivino)
            {
                _record = jugada.Intentos;
                Console.WriteLine("Tu record es de: " + _record + " intentos");
                Console.ReadKey();
            }
            if (!jugada.Adivino)
            {
                Console.WriteLine("No existe record");
                Console.ReadKey();
            }
        }

        private bool Continuar()
        {
            Console.WriteLine("desea continuar jugando? si/no");
            string continuar = Console.ReadLine();
            if (continuar.Equals("si"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int PreguntarMaximo() 
        {
            Console.WriteLine("Cual es el limite de numeros?");
            if (!int.TryParse(Console.ReadLine(), out int maximo))
            {
                throw new Exception("ingrese un numero");
            }
            if ( maximo <= 0)   
            {
                throw new Exception("ingrese un numero mayor a 0");
            }
            return maximo;
        }

        private int PreguntarNumero()
        {
            Console.WriteLine("Cual es el numero a acertar?");
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                throw new Exception("ingrese un numero");
            }
            if (numero <= 0)
            {
                throw new Exception("ingrese un numero mayor a 0");
            }
                return numero;
        }
    }
}