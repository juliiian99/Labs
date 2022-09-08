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
            UsuarioAdapter ua = new UsuarioAdapter();
            Usuario u = ua.Login(this.txtUsuario.Text, this.txtContraseña.Text);
            if (u != null)
            {
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
