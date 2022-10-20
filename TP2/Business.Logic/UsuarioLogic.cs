using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData = new Data.Database.UsuarioAdapter();

        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }

        public Business.Entities.Usuario GetOne(int ID)
        {
            return UsuarioData.GetOne(ID);
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }

        public void Save(Business.Entities.Usuario USU)
        {
            UsuarioData.Save(USU);
        }

        public void Update(Business.Entities.Usuario USU)
        {
            UsuarioData.Update(USU);
        }

        public Usuario Login (string usu, string contraseña)
        {
            return UsuarioData.Login(usu, contraseña);
        }


        public Usuario ActualizarContraseña(string us, string conNueva)
        {
            return UsuarioData.ActualizarContraseña(us, conNueva);
        }
    }
}
