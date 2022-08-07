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
    public partial class ComisionDesktop : ApplicationForm
    {
        private Comision _ComisionActual;
        public Comision ComisionActual
        {
            get { return _ComisionActual; }
            set { _ComisionActual = value; }
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
        }

        public ComisionDesktop()
        {
            InitializeComponent();
        }

        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic cl = new ComisionLogic();
            this.ComisionActual = cl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescomision.Text = this.ComisionActual.Descripcion;
            this.txtAnioespecial.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.cbIDPlan.Text = this.ComisionActual.IDPlan.ToString();

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
            this.ComisionActual = new Comision();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.ComisionActual.Descripcion = this.txtDescomision.Text;
                    this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioespecial.Text);
                    this.ComisionActual.IDPlan = int.Parse(this.cbIDPlan.Text);
                    this.ComisionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.ComisionActual.ID = int.Parse(this.txtID.Text);
                    this.ComisionActual.Descripcion = this.txtDescomision.Text;
                    this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioespecial.Text);
                    this.ComisionActual.IDPlan = int.Parse(this.cbIDPlan.Text);
                    this.ComisionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.ComisionActual.ID = int.Parse(this.txtID.Text);
                    this.ComisionActual.Descripcion = this.txtDescomision.Text;
                    this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioespecial.Text);
                    this.ComisionActual.IDPlan = int.Parse(this.cbIDPlan.Text);
                    this.ComisionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.ComisionActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }
        public new bool Validar()
        {
            if (!this.txtDescomision.Text.Equals("") && !this.txtAnioespecial.Text.Equals(""))
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
            ComisionAdapter ca = new ComisionAdapter();
            ca.Save(this.ComisionActual);
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


        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            ComisionLogic comision = new ComisionLogic();
            cbIDPlan.DataSource = comision.GetPlanes();
            cbIDPlan.ValueMember = "id_plan";
            cbIDPlan.DisplayMember = "desc_plan";
        }
    }
}
