using Business.Entities;
using Business.Logic;
using Data.Database;
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
using System.Configuration;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        private Persona _PersonaActual;
        public Persona PersonaActual
        {
            get { return _PersonaActual; }
            set { _PersonaActual = value; }
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
        }

        public PersonaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PersonaLogic pl = new PersonaLogic();
            this.PersonaActual = pl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtEmail.Text = this.PersonaActual.EMail;
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.dtFechaNac.Value = this.PersonaActual.FechaNacimiento;
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.cbTipoPersona.Text = this.PersonaActual.TipoPersona.ToString();
            this.cbIDPlan.Text = this.PersonaActual.IDPlan.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Modificar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Consultar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            this.PersonaActual = new Persona();
            switch (Modo)
            {
                case ModoForm.Alta:
                    
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.EMail = this.txtEmail.Text;
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    this.PersonaActual.FechaNacimiento = this.dtFechaNac.Value;
                    this.PersonaActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                    this.PersonaActual.TipoPersona = (Persona.TiposPersonas)this.cbTipoPersona.SelectedItem;
                    this.PersonaActual.IDPlan = Convert.ToInt32(this.cbIDPlan.SelectedValue);
                    this.PersonaActual.State = BusinessEntity.States.New;
                    
                    break;
                case ModoForm.Modificacion:
                    this.PersonaActual.ID = int.Parse(this.txtID.Text);
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.EMail = this.txtEmail.Text;
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    this.PersonaActual.FechaNacimiento = this.dtFechaNac.Value;
                    this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                    this.PersonaActual.TipoPersona = (Persona.TiposPersonas)this.cbTipoPersona.SelectedItem;
                    this.PersonaActual.IDPlan = Convert.ToInt32(this.cbIDPlan.SelectedValue);
                    this.PersonaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.PersonaActual.ID = int.Parse(this.txtID.Text);
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.EMail = this.txtEmail.Text;
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    this.PersonaActual.FechaNacimiento = this.dtFechaNac.Value;
                    this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                    this.PersonaActual.TipoPersona = (Persona.TiposPersonas)this.cbTipoPersona.SelectedValue;
                    this.PersonaActual.IDPlan = Convert.ToInt32(this.cbIDPlan.SelectedValue);
                    this.PersonaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.PersonaActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public new bool Validar()
        {
            if (!this.txtNombre.Text.Equals("") && !this.txtApellido.Text.Equals("") && !this.dtFechaNac.Text.Equals(""))
            {
                return true;
            }
            else
            {
                Notificar("Formulario Invalido", "Hay un error en algun campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PersonaAdapter pa = new PersonaAdapter();
            pa.Save(this.PersonaActual);
            if (Modo == ModoForm.Alta)
            {
                UsuarioDesktop formUsuario = new UsuarioDesktop();
                PersonaLogic p = new PersonaLogic();
                Business.Entities.Persona per = p.GetLast();
                AddOwnedForm(formUsuario);
                formUsuario.txtApellido.Text = txtApellido.Text;
                formUsuario.txtEmail.Text = txtEmail.Text;
                formUsuario.txtNombre.Text = txtNombre.Text;
                formUsuario.txtIDPersona.Text = per.ID.ToString();
                formUsuario.txtNombre.Enabled = false;
                formUsuario.txtEmail.Enabled = false;
                formUsuario.txtApellido.Enabled = false;
                formUsuario.txtIDPersona.Enabled = false;
                formUsuario.ShowDialog();
            }
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

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            PersonaLogic persona = new PersonaLogic();
            cbIDPlan.DataSource = persona.GetPlanes();
            cbIDPlan.ValueMember = "id_plan";
            cbIDPlan.DisplayMember = "desc_plan";
            cbTipoPersona.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));

            

        }
    }
}
