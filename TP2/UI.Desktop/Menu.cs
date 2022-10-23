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
    public partial class Menu : Form
    {
        public Menu(Persona Per)
        {

            InitializeComponent();
            Persona.TiposPersonas TPer = Per.TipoPersona;
            switch (TPer) 
            {
                case Persona.TiposPersonas.Docente:
                    {
                        usuariosToolStripMenuItem.Visible = false;
                        personasToolStripMenuItem.Visible = false;
                        especialidadToolStripMenuItem.Visible = false;
                        materiasToolStripMenuItem.Visible = false;
                        comisionesToolStripMenuItem.Visible = false;
                        planesToolStripMenuItem.Visible = false;
                        cursosToolStripMenuItem.Visible = false;
                        btnAgregarDocur.Visible = false;
                        break;
                    }
                case Persona.TiposPersonas.Alumno:
                    {
                        usuariosToolStripMenuItem.Visible = false;
                        personasToolStripMenuItem.Visible = false;
                        especialidadToolStripMenuItem.Visible = false;
                        materiasToolStripMenuItem.Visible = false;
                        comisionesToolStripMenuItem.Visible = false;
                        planesToolStripMenuItem.Visible = false;
                        cursosToolStripMenuItem.Visible = false;
                        btnAgregarDocur.Visible = false;
                        cbAlumnos.Visible = true;
                        AlumnoInscripcionLogic auil = new AlumnoInscripcionLogic();
                        cbAlumnos.DataSource = auil.GetAlumnos();
                        cbAlumnos.ValueMember = "id_persona";
                        cbAlumnos.DisplayMember = "legajo";
                        //cbAlumnos.ValueMember = "id_persona";

                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarioAbmc = new Usuarios();
            usuarioAbmc.ShowDialog();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personas personaABMC = new Personas();
            personaABMC.ShowDialog();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades especialidadAbmc = new Especialidades();
            especialidadAbmc.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias materiasAbmc = new Materias();
            materiasAbmc.ShowDialog();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones comisionesAbmc = new Comisiones();
            comisionesAbmc.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planAbmc = new Planes();
            planAbmc.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursoAbmc = new Cursos();
            cursoAbmc.ShowDialog();
        }

        private void btnAgregarDocur_Click(object sender, EventArgs e)
        {
            DocentesCursos docurAbmc = new DocentesCursos();
            docurAbmc.ShowDialog();
        }

        private void cbAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AlumnosInscripciones alu = new AlumnosInscripciones(Convert.ToInt32(cbAlumnos.SelectedValue));
            //AlumnosInscripciones.ID = Convert.ToInt32(cbAlumnos.SelectedValue);
            alu.ShowDialog();
            
        }
    }
}
