using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Database;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuarioActual = new UsuarioLogic();
            Usuario usuario = usuarioActual.Login(txtUsuario.Text, txtContraseña.Text);
            if (usuario is null)
            {
                MessageBox.Show("No se encontró el usuario");
            }
            else
            {
                PersonaLogic per = new PersonaLogic();
                Business.Entities.Persona persona = per.GetOne(usuario.IDPersona);
                Menu ini = new Menu(persona.TipoPersona);
                ini.ShowDialog();
            }


        }

        private void lnkOlvidaClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidaClave olvida = new OlvidaClave();
            olvida.ShowDialog();
        }
    }
}
