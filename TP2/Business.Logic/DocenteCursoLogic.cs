using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business;
using System.Data;

namespace Business.Logic
{
    public class DocenteCursoLogic
    {
        private Data.Database.DocenteCursoAdapter _DocenteCursoData = new Data.Database.DocenteCursoAdapter();

        public Data.Database.DocenteCursoAdapter DocenteCursoData
        {
            get { return _DocenteCursoData; }
            set { _DocenteCursoData = value; }
        }

        public Business.Entities.DocenteCurso GetOne(int ID)
        {
            return DocenteCursoData.GetOne(ID);
        }

        public List<Business.Entities.DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }

        public void Delete(int ID)
        {
            DocenteCursoData.Delete(ID);
        }

        public void Save(Business.Entities.DocenteCurso DOCUR)
        {
            DocenteCursoData.Save(DOCUR);
        }

        public void Update(Business.Entities.DocenteCurso DOCUR)
        {
            DocenteCursoData.Update(DOCUR);
        }

        public DataTable GetCursos()
        {
            return DocenteCursoData.GetCursos();
        }

        public DataTable GetDocentes()
        {
            return DocenteCursoData.GetDocentes();
        }
    }
}
