using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arreglo;
            arreglo = new string[5];
            int cantIteraciones = 5;
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese "+(i+1)+" string: ");
                arreglo[i] = Console.ReadLine();
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(arreglo[i]);
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}