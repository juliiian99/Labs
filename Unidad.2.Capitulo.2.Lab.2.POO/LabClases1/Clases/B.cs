﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {
        public void M4()
        {
            Console.WriteLine("Metodo del Hijo Invocado");
        }
        
        public B(string NuevaInstancia) : base(NuevaInstancia)
        {
        }

        public B() : base("Instancia de B")
        {

        }
        public void F() { Console.WriteLine("B.F"); }
        public void G() { Console.WriteLine("B.G"); }

    }
}