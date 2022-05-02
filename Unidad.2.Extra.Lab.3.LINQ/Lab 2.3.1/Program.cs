using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq linq = new Linq();

            List<string> provincias = linq.ObtenerProvinciasQueEmpiezanConDetermindasLetrasTest();
            var provinciasST = (from p in provincias where p.StartsWith("S") || p.StartsWith("T") select p);

            foreach (string pST in provinciasST)
            {
                Console.WriteLine(pST);
            }
            Console.ReadLine();

            List<int> nums = linq.ObtenerNumerosMayoresA20Test();

            var mayoresA20 = (from n in nums where n > 20 select n);

            foreach (int n in mayoresA20)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            List<Ciudad> ciudades = linq.ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest();

            string buscar = Console.ReadLine();
            var resultados = (from c in ciudades where c.Nombre.ToLower().Contains(buscar) select c.CodigoPostal);

            foreach (var r in resultados)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();

            var empleados = linq.AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest();
            var empleadosAsc = (from e in empleados orderby e.Sueldo ascending select new { e.Nombre, e.Sueldo });
            var empleadosDesc = (from e in empleados orderby e.Sueldo descending select new { e.Nombre, e.Sueldo });

            foreach (var e in empleadosAsc)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

            foreach (var e in empleadosDesc)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

        }
    }
}
