using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {
        public string M4()
        {
            return "Metodo del Hijo Invocado";
        }
        
        
        public B(string NuevaInstancia) : base(NuevaInstancia)
        {
        }

        public B() : base("Instancia de B")
        {

        }

     
    }
}