using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Juego juego = new Juego();
                juego.ComenzarJuego();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
