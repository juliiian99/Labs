using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic 
    {
        private Data.Database.CursoAdapter _CursoData = new Data.Database.CursoAdapter();

        public Data.Database.CursoAdapter CursoData
        {
            get { return _CursoData; }
            set { _CursoData = value; }
        }

        public Business.Entities.Curso GetOne(int ID)
        {
            return CursoData.GetOne(ID);
        }

        public List<Business.Entities.Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public void Delete(int ID)
        {
            CursoData.Delete(ID);
        }

        public void Save(Business.Entities.Curso CUR)
        {
            CursoData.Save(CUR);
        }

        public void Update(Business.Entities.Curso CUR)
        {
            CursoData.Update(CUR);
        }

        public DataTable GetMaterias() 
        {
            return CursoData.GetMaterias();
        }

        public DataTable GetComisiones()
        {
            return CursoData.GetComisiones();
        }

        public void CambiaCupo(Curso cur, int i)
        {
            CursoData.CambiaCupo(cur, i);
        }

        //public DataTable GetCursosDocente(int id_per)
        //{
        //    return CursoData.GetCursosDocente(id_per);
        //}

    }
}
