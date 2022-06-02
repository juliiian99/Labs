using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabClases3
{
    public class Persona
    {
        private string Nombre
        {
            get => default;
            set
            {
            }
        }

        private string Apellido
        {
            get => default;
            set
            {
            }
        }

        private int Edad
        {
            get => default;
            set
            {
            }
        }

        private string DNI
        {
            get => default;
            set
            {
            }
        }

        public Persona(int Edad, string Nombre, string Apellido, string DNI)
        {
            this.Edad = Edad;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }

        ~Persona()
        {
            Console.WriteLine("Objeto destruido");
        }

        public string GetFullName()
        {
            return this.Nombre + ' ' + this.Apellido;
        }

        public int getAge()
        {
            return this.Edad;
        }
    }
}