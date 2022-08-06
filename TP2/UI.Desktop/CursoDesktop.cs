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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }

        private Curso _CursoActual;

        public Curso CursoActual
        {
            get { return _CursoActual; }
            set { _CursoActual = value; }
        }


        public CursoDesktop(ModoForm modo) : this()
        {

        }
        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoLogic cl = new CursoLogic();
            this.CursoActual = cl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtIDCurso.Text = this.CursoActual.ID.ToString();
            this.cbIDMateria.SelectedValue = this.CursoActual.IDMateria.ToString();
            this.cbIDComision.SelectedValue = this.CursoActual.IDComision.ToString();
            this.txtAnioCalendario.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
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
            this.CursoActual = new Curso();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.CursoActual.IDMateria = Convert.ToInt32(cbIDMateria.SelectedValue);
                    this.CursoActual.IDComision = Convert.ToInt32(cbIDComision.SelectedValue);
                    this.CursoActual.AnioCalendario = int.Parse(txtAnioCalendario.Text);
                    this.CursoActual.Cupo = int.Parse(txtCupo.Text);
                    this.CursoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.CursoActual.ID = int.Parse(this.txtIDCurso.Text);
                    this.CursoActual.IDMateria = Convert.ToInt32(cbIDMateria.SelectedValue);
                    this.CursoActual.IDComision = Convert.ToInt32(cbIDComision.SelectedValue);
                    this.CursoActual.AnioCalendario = int.Parse(txtAnioCalendario.Text);
                    this.CursoActual.Cupo = int.Parse(txtCupo.Text);
                    this.CursoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.CursoActual.ID = int.Parse(this.txtIDCurso.Text);
                    this.CursoActual.IDMateria = Convert.ToInt32(cbIDMateria.SelectedValue);
                    this.CursoActual.IDComision = Convert.ToInt32(cbIDComision.SelectedValue);
                    this.CursoActual.AnioCalendario = int.Parse(txtAnioCalendario.Text);
                    this.CursoActual.Cupo = int.Parse(txtCupo.Text);
                    this.CursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.CursoActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public new bool Validar()
        {
            MateriaLogic materiaActual = new MateriaLogic();
            var materia = materiaActual.GetOne(Convert.ToInt32(cbIDMateria.SelectedValue));
            ComisionLogic comisionActual = new ComisionLogic();
            var comision = comisionActual.GetOne(Convert.ToInt32(cbIDComision.SelectedValue));
            if (!this.txtAnioCalendario.Text.Equals("") && !this.txtCupo.Text.Equals(""))
            {
                return true;
            }
            else
            {
                this.Notificar("Debe completar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoAdapter ca = new CursoAdapter();
            ca.Save(this.CursoActual);
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

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            CursoLogic curso = new CursoLogic();
            cbIDMateria.DataSource = curso.GetMaterias();
            cbIDComision.DataSource = curso.GetComisiones();
            cbIDMateria.ValueMember = "id_materia";
            cbIDMateria.DisplayMember = "desc_materia";
            cbIDComision.ValueMember = "id_comision";
            cbIDComision.DisplayMember = "desc_comision";

        }
    }
}
