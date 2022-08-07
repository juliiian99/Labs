using Business.Entities;
using Business.Logic;
using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        private Plan _PlanActual;
        public Plan PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }
        public PlanDesktop(ModoForm modo) : this()
        {}

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PlanLogic pl = new PlanLogic();
            this.PlanActual = pl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtIDPlan.Text = this.PlanActual.ID.ToString();
            this.txtDescPlan.Text = this.PlanActual.Descripcion;
            this.cbIDEspecialidad.SelectedValue = this.PlanActual.IDEspecialidad.ToString();

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
            this.PlanActual = new Plan();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.PlanActual.Descripcion = this.txtDescPlan.Text;
                    this.PlanActual.IDEspecialidad = Convert.ToInt32(this.cbIDEspecialidad.SelectedValue);
                    this.PlanActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.PlanActual.ID = int.Parse(this.txtIDPlan.Text);
                    this.PlanActual.Descripcion = this.txtDescPlan.Text;
                    this.PlanActual.IDEspecialidad = Convert.ToInt32(this.cbIDEspecialidad.SelectedValue);
                    this.PlanActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.PlanActual.ID = int.Parse(this.txtIDPlan.Text);
                    this.PlanActual.Descripcion = this.txtDescPlan.Text;
                    this.PlanActual.IDEspecialidad = Convert.ToInt32(this.cbIDEspecialidad.SelectedValue);
                    this.PlanActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.PlanActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public new bool Validar()
        {
            if (!this.txtDescPlan.Text.Equals("") )
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
            PlanAdapter pa = new PlanAdapter();
            pa.Save(this.PlanActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
            else this.Notificar("Error en algun campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic plan = new PlanLogic();
            cbIDEspecialidad.DataSource = plan.GetEspecialidades();
            cbIDEspecialidad.ValueMember = "id_especialidad";
            cbIDEspecialidad.DisplayMember = "desc_especialidad";
        }
    }
}
