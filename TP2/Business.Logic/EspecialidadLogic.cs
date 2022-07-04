using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic
    {
        private Data.Database.EspecialidadAdapter _EspecialidadData = new Data.Database.EspecialidadAdapter();

        public Data.Database.EspecialidadAdapter EspecialidadData {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            return EspecialidadData.GetOne(ID);
        }

        public List<Business.Entities.Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public void Delete(int ID)
        {
            EspecialidadData.Delete(ID);
        }

        public void Save(Business.Entities.Especialidad ESP)
        {
            EspecialidadData.Save(ESP);
        }

        public void Update(Business.Entities.Especialidad ESP)
        {
            EspecialidadData.Update(ESP);
        }
    }
}
