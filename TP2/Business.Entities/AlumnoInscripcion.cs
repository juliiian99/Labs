using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private string _Condicion;
        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        private int _IDAlumno;
        public int IDAlumno
        {
            get { return _IDAlumno; }
            set { _IDAlumno = value; }
        }

        private Persona _alumno;
        public Persona Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }

        private int _IDCurso;
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }


        private Curso _curso;
        public Curso Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        private int _Nota;
        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
    }
}
