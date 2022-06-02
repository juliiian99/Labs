using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class A
    {
        protected string NombreInstancia;
        public A()
        {
            this.NombreInstancia = "Instancia sin nombre";
        } //Contructor por default

        public A(string NombreInstancia)
        {
            this.NombreInstancia = NombreInstancia;
        } //Constructor con un parametro
        public string MostrarNombre()
        {
            this.M1();
            this.M2();
            this.M3();
            return this.NombreInstancia;
        }
        public void M1()
        {
            Console.WriteLine("se invocó el método 1");
        }
        public void M2 ()
        {
            Console.WriteLine("se invocó el método 2");
        }
        public void M3()
        {
            Console.WriteLine("se invocó el método 3");
        }
        public void F() { Console.WriteLine("A.F"); }
        public virtual void G() { Console.WriteLine("A.G"); }

    }
}
