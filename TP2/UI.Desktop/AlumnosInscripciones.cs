using Business.Logic;
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
    public partial class AlumnosInscripciones : Form
    {
        //public static int ID;
        //public AlumnosInscripciones(int id)
        //{
        //    id = ID;
        //}
        static class Global
        {
            public static int ID;
        }

        public AlumnosInscripciones(int id)
        {
            Global.ID = id;
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            AlumnoInscripcionLogic ml = new AlumnoInscripcionLogic();
            this.dgvAlumnoInscripcion.DataSource = ml.GetAll(Global.ID);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionDesktop form = new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Alta, Global.ID);
            form.ShowDialog();
            Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)this.dgvAlumnoInscripcion.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionDesktop form = new AlumnoInscripcionDesktop(ID, ApplicationForm.ModoForm.Modificacion, Global.ID);
            form.ShowDialog();
            Listar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)this.dgvAlumnoInscripcion.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionDesktop form = new AlumnoInscripcionDesktop(ID, ApplicationForm.ModoForm.Consulta, Global.ID);
            form.ShowDialog();
            Listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)this.dgvAlumnoInscripcion.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionDesktop form = new AlumnoInscripcionDesktop(ID, ApplicationForm.ModoForm.Baja, Global.ID);
            form.ShowDialog();
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
