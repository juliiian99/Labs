using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic
    {
        private Data.Database.AlumnoInscripcionAdapter _AlumnoInscripcionData = new Data.Database.AlumnoInscripcionAdapter();

        public Data.Database.AlumnoInscripcionAdapter AlumnoInscripcionData
        {
            get { return _AlumnoInscripcionData; }
            set { _AlumnoInscripcionData = value; }
        }

        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            return AlumnoInscripcionData.GetOne(ID);
        }

        public List<Business.Entities.AlumnoInscripcion> GetAll(int id)
        {
            return AlumnoInscripcionData.GetAll(id);
        }

        public void Delete(int ID)
        {
            AlumnoInscripcionData.Delete(ID);
        }

        public void Save(Business.Entities.AlumnoInscripcion ALUI)
        {
            AlumnoInscripcionData.Save(ALUI);
        }

        public void Update(Business.Entities.AlumnoInscripcion ALUI)
        {
            AlumnoInscripcionData.Update(ALUI);
        }

        public DataTable GetCursos(int id)
        {
            return AlumnoInscripcionData.GetCursos(id);
        }

        public DataTable GetAlumnos()
        {
            return AlumnoInscripcionData.GetAlumnos();
        }

        public List<Business.Entities.AlumnoInscripcion> GetAlumnosCurso(int id)
        {
            return AlumnoInscripcionData.GetAlumnosCurso(id);
        }
    }
}
