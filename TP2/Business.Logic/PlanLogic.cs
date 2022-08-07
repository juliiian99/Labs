using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PlanLogic
    {
        private Data.Database.PlanAdapter _PlanData = new Data.Database.PlanAdapter();

        public Data.Database.PlanAdapter PlanData
        {
            get { return _PlanData; }
            set { _PlanData = value; }
        }

        public Business.Entities.Plan GetOne(int ID)
        {
            return PlanData.GetOne(ID);
        }

        public List<Business.Entities.Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public void Delete(int ID)
        {
            PlanData.Delete(ID);
        }

        public void Save(Business.Entities.Plan ESP)
        {
            PlanData.Save(ESP);
        }

        public void Update(Business.Entities.Plan ESP)
        {
            PlanData.Update(ESP);
        }

        public DataTable GetEspecialidades()
        {
            return PlanData.GetEspecialidades();
        }

    }
}
