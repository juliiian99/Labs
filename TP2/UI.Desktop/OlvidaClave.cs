using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class OlvidaClave : Form
    {
        public OlvidaClave()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            var usu = ul.ActualizarContraseña(txtUsuario.Text, txtNuevaClave.Text);
            if (!(usu is null)) 
            {
                MessageBox.Show("La contraseña se cambio con exito", "Nueva contraseña" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de usuario no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
