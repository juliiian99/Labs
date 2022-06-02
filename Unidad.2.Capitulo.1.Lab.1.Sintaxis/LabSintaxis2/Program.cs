using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        public static object ToUpper { get; private set; }
        public int Length { get; }

        static void Main(string[] args)
        { // con if anidados
            Console.WriteLine("Ingresar un texto: ");

            string inputTexto;
            inputTexto = Console.ReadLine();
            if (inputTexto != "")
            {
                Console.WriteLine("Ingrese opcion 1: MAYUSCULAS, 2: minusculas, 3: largo del texto");
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.D1)
                    Console.WriteLine(inputTexto.ToUpper());
                else if (opcion.Key == ConsoleKey.D2)
                    Console.WriteLine(inputTexto.ToLower());
                else if (opcion.Key == ConsoleKey.D3)
                    Console.WriteLine(inputTexto.Length);
                else Console.WriteLine("opcion no valida");
            }
            else Console.WriteLine("No ingreso un texto"); Console.ReadKey();
            // con estructura case
            {
                Console.WriteLine("Ingresar un texto: ");

                string inputText;
                inputText = Console.ReadLine();
                if (inputText != "")
                {

                    Console.WriteLine("Ingrese 1: MAYUSCULAS, 2: minusculas, 3: largo del texto");
                    ConsoleKeyInfo opcion = Console.ReadKey();
                    switch (opcion.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(inputText.ToUpper());
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine(inputText.ToLower());
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(inputText.Length);
                            break;
                        default:
                            Console.WriteLine("No ingreso texto");
                            break;
                    }
                    Console.ReadKey();
                }
                else Console.WriteLine("No ingreso texto"); Console.ReadKey();
            }

        }


    }

}

