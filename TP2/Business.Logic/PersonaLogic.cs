using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PersonaLogic
    {
        private Data.Database.PersonaAdapter _PersonaData = new Data.Database.PersonaAdapter();

        public Data.Database.PersonaAdapter PersonaData
        {
            get { return _PersonaData; }
            set { _PersonaData = value; }
        }

        public Business.Entities.Persona GetOne(int ID)
        {
            return PersonaData.GetOne(ID);
        }

        public Business.Entities.Persona GetLast()
        {
            return PersonaData.GetLast();
        }

        public List<Business.Entities.Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public void Delete(int ID)
        {
            PersonaData.Delete(ID);
        }

        public void Save(Business.Entities.Persona PER)
        {
            PersonaData.Save(PER);
        }

        public void Update(Business.Entities.Persona PER)
        {
            PersonaData.Update(PER);
        }

        public DataTable GetPlanes()
        {
            return PersonaData.GetPlanes();
        }

    }
}
