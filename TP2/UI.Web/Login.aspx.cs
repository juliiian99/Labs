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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioAdapter ua = new UsuarioAdapter();
            Usuario u = ua.Login(this.txtUsuario.Text, this.txtClave.Text);

            if (u.NombreUsuario != null)
            {
                Page.Response.Redirect("https://localhost:44385/");
            }
            else
            {
                Page.Response.Write("<script>alert('Usuario y/o clave incorrecta')</script>");
            }
        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("OlvidaClave.aspx");
        }
    }
}