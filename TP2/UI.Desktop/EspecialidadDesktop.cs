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

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private Especialidad _EspecialidadActual;

        public Especialidad EspecialidadActual {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
        }

        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        public EspecialidadDesktop(ModoForm modo) : this()
        {

        }
        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic el = new EspecialidadLogic();
            this.EspecialidadActual = el.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    Desactivar();
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Modificar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Consultar";
                    Desactivar();
                    break;
            }
        }

        public void Desactivar()
        {
            txtDescripcion.Enabled = false;
        }

        public override void MapearADatos()
        {
            this.EspecialidadActual = new Especialidad();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                    this.EspecialidadActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                    this.EspecialidadActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.EspecialidadActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }
        public new bool Validar()
        {
            if (!this.txtDescripcion.Text.Equals(""))
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
            EspecialidadAdapter ea = new EspecialidadAdapter();
            ea.Save(this.EspecialidadActual);
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
    }
}
