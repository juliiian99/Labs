using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace UI.Desktop
{
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
        }

        private DocenteCurso _DocenteCursoActual;
        public DocenteCurso DocenteCursoActual
        {
            get { return _DocenteCursoActual; }
            set { _DocenteCursoActual = value; }
        }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
        }

        public DocenteCursoDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            this.DocenteCursoActual = dcl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.DocenteCursoActual.ID.ToString();
            this.cbDocente.SelectedValue = this.DocenteCursoActual.IDDocente;
            this.cbIDCurso.SelectedValue = this.DocenteCursoActual.IDCurso;
            this.cbCargo.SelectedValue = this.DocenteCursoActual.Cargo;
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.Ver(true);
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.Ver(false);
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.Ver(true);
                    this.btnAceptar.Text = "Modificar";
                    break;
                case ModoForm.Consulta:
                    this.Ver(false);
                    this.btnAceptar.Text = "Consultar";
                    break;
            }
        }

        public void Ver(Boolean ver)
        {
            cbCargo.Enabled = ver;
            cbDocente.Enabled = ver;
            cbIDCurso.Enabled = ver;
        }

        public override void MapearADatos()
        {
            this.DocenteCursoActual = new DocenteCurso();
            switch (Modo)
            {
                case ModoForm.Alta:

                    this.DocenteCursoActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.cbDocente.SelectedValue);
                    this.DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)(this.cbCargo.SelectedValue);
                    this.DocenteCursoActual.State = BusinessEntity.States.New;

                    break;
                case ModoForm.Modificacion:
                    this.DocenteCursoActual.ID = int.Parse(this.txtID.Text);
                    this.DocenteCursoActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.cbDocente.SelectedValue);
                    this.DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)(this.cbCargo.SelectedValue);
                    this.DocenteCursoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.DocenteCursoActual.ID = int.Parse(this.txtID.Text);
                    this.DocenteCursoActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.cbDocente.SelectedValue);
                    this.DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)(this.cbCargo.SelectedValue);
                    this.DocenteCursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.DocenteCursoActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        private void DocenteCursoDesktop_Load(object sender, EventArgs e)
        {
            DocenteCursoLogic docur = new DocenteCursoLogic();
            cbDocente.DataSource = docur.GetDocentes();
            cbDocente.DisplayMember =  ("nombre");
            cbDocente.ValueMember = "id_persona";
            cbIDCurso.DataSource = docur.GetCursos();
            cbIDCurso.DisplayMember = "id_curso";
            cbIDCurso.ValueMember = "id_curso";
            //cbIDCurso.SelectedIndex = 0;
            cbCargo.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(Convert.ToInt32(this.cbIDCurso.SelectedValue));
            MateriaLogic ml = new MateriaLogic();
            Materia mat = ml.GetOne(cur.IDMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic col = new ComisionLogic();
            Comision com = col.GetOne(cur.IDComision);
            lblComision.Text = com.Descripcion;
        }

        private void cbIDCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(Convert.ToInt32(this.cbIDCurso.SelectedValue));
            MateriaLogic ml = new MateriaLogic();
            Materia mat = ml.GetOne(cur.IDMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic col = new ComisionLogic();
            Comision com = col.GetOne(cur.IDComision);
            lblComision.Text = com.Descripcion;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoAdapter dca = new DocenteCursoAdapter();
            dca.Save(this.DocenteCursoActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
