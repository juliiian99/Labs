using System;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            new Usuarios().Menu();
        }
    }
}
