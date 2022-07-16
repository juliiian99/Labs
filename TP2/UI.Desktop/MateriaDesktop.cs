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
    public partial class MateriaDesktop : ApplicationForm
    {
        private Materia _MateriaActual;
        public Materia MateriaActual
        {
            get { return _MateriaActual; }
            set { _MateriaActual = value; }
        }
        public MateriaDesktop(ModoForm modo) : this()
        {
        }

        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic ml = new MateriaLogic();
            this.MateriaActual = ml.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescMateria.Text = this.MateriaActual.Descripcion;
            this.txtHsSemana.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHorasAnual.Text = this.MateriaActual.HSTotales.ToString();
            this.txtIDPlan.Text = this.MateriaActual.IDPlan.ToString();

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
            this.MateriaActual = new Materia();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.MateriaActual.Descripcion = this.txtDescMateria.Text;
                    this.MateriaActual.HSSemanales = int.Parse(this.txtHsSemana.Text);
                    this.MateriaActual.HSTotales = int.Parse(this.txtHorasAnual.Text);
                    this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text);
                    this.MateriaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.MateriaActual.ID = int.Parse(this.txtID.Text);
                    this.MateriaActual.Descripcion = this.txtDescMateria.Text;
                    this.MateriaActual.HSSemanales = int.Parse(this.txtHsSemana.Text);
                    this.MateriaActual.HSTotales = int.Parse(this.txtHorasAnual.Text);
                    this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text);
                    this.MateriaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.MateriaActual.ID = int.Parse(this.txtID.Text);
                    this.MateriaActual.Descripcion = this.txtDescMateria.Text;
                    this.MateriaActual.HSSemanales = int.Parse(this.txtHsSemana.Text);
                    this.MateriaActual.HSTotales = int.Parse(this.txtHorasAnual.Text);
                    this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text);
                    this.MateriaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.MateriaActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public new bool Validar()
        {
            PlanLogic planActual = new PlanLogic();
            var plan = planActual.GetOne(Convert.ToInt32(txtIDPlan.Text));
            if (!this.txtDescMateria.Text.Equals("") && !this.txtHsSemana.Text.Equals("") &&
                !this.txtHorasAnual.Text.Equals("") && !this.txtIDPlan.Text.Equals(""))
            {
                if (!(plan is null)) return true;
                else return false;
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
            MateriaAdapter ma = new MateriaAdapter();
            ma.Save(this.MateriaActual);
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

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
        }
    }
}
