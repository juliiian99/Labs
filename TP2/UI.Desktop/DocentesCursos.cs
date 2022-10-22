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
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            this.dgvDocentesCursos.DataSource = dcl.GetAll();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop formDocur= new DocenteCursoDesktop(ApplicationForm.ModoForm.Alta);
            formDocur.ShowDialog();
            this.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop form = new DocenteCursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            form.ShowDialog();
            this.Listar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop form = new DocenteCursoDesktop(ID, ApplicationForm.ModoForm.Consulta);
            form.ShowDialog();
            this.Listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop form = new DocenteCursoDesktop(ID, ApplicationForm.ModoForm.Baja);
            form.ShowDialog();
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
