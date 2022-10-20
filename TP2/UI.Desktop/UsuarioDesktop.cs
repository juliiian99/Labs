using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario _UsuarioActual;

        public Usuario UsuarioActual{
           get { return _UsuarioActual; }
           set { _UsuarioActual = value; }
        }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic ul = new UsuarioLogic();
            this.UsuarioActual = ul.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos() {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            this.txtIDPersona.Text = this.UsuarioActual.IDPersona.ToString();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Modificacion";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Consulta";
                    break;
            }
        }

        public override void MapearADatos()
        {
            this.UsuarioActual = new Usuario();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre  = this.txtNombre.Text;
                    this.UsuarioActual.Apellido  = this.txtApellido.Text;
                    this.UsuarioActual.EMail = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave  = this.txtClave.Text;
                    this.UsuarioActual.IDPersona = Convert.ToInt32(txtIDPersona.Text);
                    this.UsuarioActual.State = BusinessEntity.States.New;
            break;
                case ModoForm.Modificacion:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.EMail = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.IDPersona = Convert.ToInt32(this.txtIDPersona.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.EMail = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.IDPersona = Convert.ToInt32(this.txtIDPersona.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.UsuarioActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }
        public new bool Validar()
        {
            Regex ValidEmailRegex = CreateValidEmailRegex();
            if (!this.txtApellido.Text.Equals("") &&
                !this.txtClave.Text.Equals("") &&
                !this.txtEmail.Text.Equals("") &&
                !this.txtNombre.Text.Equals("") &&
                !this.txtUsuario.Text.Equals("") &&
                this.txtClave.Text.Equals(this.txtConfirmarClave.Text) &&
                ValidEmailRegex.IsMatch(this.txtEmail.Text))
            {
                return true;
            }
            else
            {
                Notificar("Formulario Invalido", "Hay un error en algun campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public override void GuardarCambios() {
            MapearADatos();
            UsuarioAdapter ua = new UsuarioAdapter();
            ua.Save(this.UsuarioActual);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
