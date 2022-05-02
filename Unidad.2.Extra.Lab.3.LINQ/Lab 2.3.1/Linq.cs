using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._3._1
{
    public class Linq
    {
        public List<string> ObtenerProvinciasQueEmpiezanConDetermindasLetrasTest()
        {
            // Arrange
            List<string> provincias = new List<string>
            {
                "Buenos Aires",
                "Capital Federal",
                "Catamarca",
                "Chaco",
                "Chubut",
                "Córdoba",
                "Corrientes",
                "Entre Ríos",
                "Formosa",
                "Jujuy",
                "La Pampa",
                "La Rioja",
                "Mendoza",
                "Misiones",
                "Neuquén",
                "Río Negro",
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago del Estero",
                "Tierra del Fuego, Antártida e Isla del Atlántico Sur",
                "Tucumán"
            };
            return provincias;
        }

        public List<int> ObtenerNumerosMayoresA20Test()
        {
            // Arrange
            List<int> numeros = new List<int> { 14, 2, 5, 21, 32, 25, 20 };

            return numeros;
        }

        public List<Ciudad> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest()
        {
            // Arrange
            List<Ciudad> ciudades = new List<Ciudad>
            {
                 new Ciudad() { Nombre = "Rosario", CodigoPostal = 2000 },
                 new Ciudad()
                 {
                     Nombre = "Córdoba",
                     CodigoPostal = 5000
                 },
                new Ciudad()
                {
                    Nombre = "Santa Fe",
                    CodigoPostal = 3000
                },
                new Ciudad() {
                    Nombre = "San Miguel De Tucuman",
                    CodigoPostal = 4000
                },
                new Ciudad() {
                    Nombre = "Buenos Aires",
                    CodigoPostal = 4000
                },
                new Ciudad() {
                    Nombre = "Pasos de los Libres",
                    CodigoPostal = 3230
                },
                new Ciudad() {
                    Nombre = "Villada",
                    CodigoPostal = 2173
                },
                new Ciudad() {
                    Nombre = "Parana",
                    CodigoPostal = 8000
                },
                new Ciudad() {
                    Nombre = "Corrientes",
                    CodigoPostal = 1000
                },
                new Ciudad() {
                    Nombre = "Mendoza",
                    CodigoPostal = 9000
                }
            };
            return ciudades;
        }

        public List<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest()
        {
            List<Empleado> empleados = new List<Empleado> { new Empleado() { Id = 1, Nombre = "Gabriela F", Sueldo = 1600.0 }, new Empleado() { Id = 2, Nombre = "Federico R", Sueldo = 1200.0 } };
            List<Empleado> empleadosParaAgregar = new List<Empleado> { new Empleado() { Id = 3, Nombre = "Juan D", Sueldo = 1500.0 }, new Empleado() { Id = 4, Nombre = "Jesus T", Sueldo = 1610.5 } };

            foreach (Empleado ea in empleadosParaAgregar)
            {
                empleados.Add(ea);
            }

            return empleados;
        }
    }
}
