using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class MateriaLogic
    {
        private Data.Database.MateriaAdapter _MateriaData = new Data.Database.MateriaAdapter();

        public Data.Database.MateriaAdapter MateriaData
        {
            get { return _MateriaData; }
            set { _MateriaData = value; }
        }

        public Business.Entities.Materia GetOne(int ID)
        {
            return MateriaData.GetOne(ID);
        }

        public List<Business.Entities.Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public void Delete(int ID)
        {
            MateriaData.Delete(ID);
        }

        public void Save(Business.Entities.Materia MAT)
        {
            MateriaData.Save(MAT);
        }

        public void Update(Business.Entities.Materia MAT)
        {
            MateriaData.Update(MAT);
        }

        public DataTable GetPlanes()
        {
            return MateriaData.GetPlanes();
        }
    }
}
