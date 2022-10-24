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
    public partial class AlumnoInscripcionDesktop : ApplicationForm
    {

        static class Global
        {
            public static int ID;
        }
        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }

        //public AlumnoInscripcionDesktop(int id)
        //{
        //    InitializeComponent();
        //    Global.ID = id;
        //}

        private AlumnoInscripcion _AlumnoInscripcionActual;
        public AlumnoInscripcion AlumnoInscripcionActual
        {
            get { return _AlumnoInscripcionActual; }
            set { _AlumnoInscripcionActual = value; }
        }
        public AlumnoInscripcionDesktop(ModoForm modo, int id) : this()
        {
            Global.ID = id;
        }

        public void Listar()
        {
            CursoLogic c = new CursoLogic();
            Curso cur = c.GetOne(Convert.ToInt32(cbIDCurso.SelectedValue));
            MateriaLogic m = new MateriaLogic();
            Materia mat = m.GetOne(cur.IDMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic com = new ComisionLogic();
            Comision comi = com.GetOne(cur.IDComision);
            lblComision.Text = comi.Descripcion;
            txtIDAlumno.Text = Global.ID.ToString();
        }

        public AlumnoInscripcionDesktop(int ID, ModoForm modo, int id_alumno) : this()
        {
            Global.ID = id_alumno;
            this.Modo = modo;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            this.AlumnoInscripcionActual = ail.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.AlumnoInscripcionActual.ID.ToString();
            this.txtIDAlumno.Text = Global.ID.ToString();
            this.cbIDCurso.SelectedValue = this.AlumnoInscripcionActual.IDCurso.ToString();
            this.cbCondicion.SelectedValue = this.AlumnoInscripcionActual.Condicion.ToString();
            this.nNota.Value = this.AlumnoInscripcionActual.Nota;
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
            cbCondicion.Enabled = false;
            cbIDCurso.Enabled = false;
        }

        public override void MapearADatos()
        {
            this.AlumnoInscripcionActual = new AlumnoInscripcion();
            CursoLogic ca = new CursoLogic();
            Curso cur= ca.GetOne(Convert.ToInt32(cbIDCurso.SelectedValue));
            switch (Modo)
            {
                case ModoForm.Alta:
                    if(cur.Cupo != 0)
                    {
                        this.AlumnoInscripcionActual.IDAlumno = Global.ID;
                        this.AlumnoInscripcionActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                        this.AlumnoInscripcionActual.Condicion = this.cbCondicion.SelectedItem.ToString();
                        this.AlumnoInscripcionActual.Nota = Convert.ToInt32(this.nNota.Value);
                        //CursoAdapter ca = new CursoAdapter();
                        //ca.GetOne(Convert.ToInt32(cbIDCurso.SelectedValue));
                        int i = -1; ca.CambiaCupo(cur, i);
                        this.AlumnoInscripcionActual.State = BusinessEntity.States.New;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Cupo agotado!");
                        break;
                    }                    
                case ModoForm.Modificacion:
                    this.AlumnoInscripcionActual.ID = int.Parse(this.txtID.Text);
                    this.AlumnoInscripcionActual.IDAlumno = Global.ID;
                    this.AlumnoInscripcionActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.AlumnoInscripcionActual.Condicion = this.cbCondicion.SelectedItem.ToString();
                    this.AlumnoInscripcionActual.Nota = Convert.ToInt32(this.nNota.Value);
                    this.AlumnoInscripcionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.AlumnoInscripcionActual.ID = int.Parse(this.txtID.Text);
                    this.AlumnoInscripcionActual.IDAlumno = Global.ID;
                    this.AlumnoInscripcionActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.AlumnoInscripcionActual.Condicion = this.cbCondicion.SelectedItem.ToString();
                    this.AlumnoInscripcionActual.Nota = Convert.ToInt32(this.nNota.Value);
                    int e = 1; ca.CambiaCupo(cur, e);
                    this.AlumnoInscripcionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.AlumnoInscripcionActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if(AlumnoInscripcionActual.IDCurso!= 0)
            {
                AlumnoInscripcionAdapter aia = new AlumnoInscripcionAdapter();
                aia.Save(this.AlumnoInscripcionActual);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlumnoInscripcionDesktop_Load(object sender, EventArgs e)
        {
            AlumnoInscripcionLogic alui = new AlumnoInscripcionLogic();
            cbIDCurso.DataSource = alui.GetCursos(Global.ID);
            cbIDCurso.ValueMember = "id_curso";
            cbIDCurso.DisplayMember = "id_curso";

            CursoLogic c = new CursoLogic();
            Curso cur = c.GetOne(Convert.ToInt32(cbIDCurso.SelectedValue));
            MateriaLogic m = new MateriaLogic();
            Materia mat = m.GetOne(cur.IDMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic com = new ComisionLogic();
            Comision comi = com.GetOne(cur.IDComision);
            lblComision.Text = comi.Descripcion;
        }



        private void cbIDCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CursoLogic c = new CursoLogic();
            Curso cur = c.GetOne(Convert.ToInt32(cbIDCurso.SelectedValue));
            MateriaLogic m = new MateriaLogic();
            Materia mat = m.GetOne(cur.IDMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic com = new ComisionLogic();
            Comision comi = com.GetOne(cur.IDComision);
            lblComision.Text = comi.Descripcion;
        }
    }
}
