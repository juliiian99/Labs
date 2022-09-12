using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace UI.Web
{
    public partial class OlvidaClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            var usu = ul.ActualizarContraseña(txtUsuario.Text, txtNuevaClave.Text); // no funca
            if (!(usu is null))
            {
                Page.Response.Write("La contraseña se cambio con exito");
                Page.Response.Redirect("Login.aspx");
            }
            else
            {
                Page.Response.Write("Nombre de usuario no valido");
            }

        }
    }
}