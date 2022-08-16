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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            PersonaLogic pl = new PersonaLogic();
            this.dgvPersonas.DataSource = pl.GetAll();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            PersonaDesktop formPersona = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Consulta);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Baja);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
