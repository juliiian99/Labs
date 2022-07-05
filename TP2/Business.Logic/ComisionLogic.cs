using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionLogic
    {
        private Data.Database.ComisionAdapter _ComisionData = new Data.Database.ComisionAdapter();

        public Data.Database.ComisionAdapter ComisionData
        {
            get { return _ComisionData; }
            set { _ComisionData = value; }
        }

        public Business.Entities.Comision GetOne(int ID)
        {
            return ComisionData.GetOne(ID);
        }

        public List<Business.Entities.Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public void Delete(int ID)
        {
            ComisionData.Delete(ID);
        }

        public void Save(Business.Entities.Comision COM)
        {
            ComisionData.Save(COM);
        }

        public void Update(Business.Entities.Comision COM)
        {
            ComisionData.Update(COM);
        }
    }
}
