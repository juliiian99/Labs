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


namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            EspecialidadLogic ul = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = ul.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Consulta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
