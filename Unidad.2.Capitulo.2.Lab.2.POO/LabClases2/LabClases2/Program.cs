using Clases;
using System;

namespace LabClases2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = b;
            a.F();
            a.G();
            b.F();
            b.G();
            Console.ReadKey();

        }
    }
}
