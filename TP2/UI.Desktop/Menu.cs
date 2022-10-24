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
        static class Global
        {
            static public Persona Pers;
        }

        public Menu(Persona Per)
        {
            Global.Pers = Per;
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
                        reportesToolStripMenuItem.Visible = false;
                        btnAgregarDocur.Visible = false;
                        cbAlumnos.Visible = false;
                        lblElegir.Visible = false;
                        lblCurso.Visible = true;
                        cbCursos.Visible = true;
                        DocenteCursoLogic dl = new DocenteCursoLogic();
                        cbCursos.DataSource= dl.GetCursoss(Global.Pers.ID);
                        cbCursos.DisplayMember = "id_curso";
                        cbCursos.ValueMember = "id_curso";
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
                        reportesToolStripMenuItem.Visible = false;
                        btnAgregarDocur.Visible = false;
                        cbAlumnos.Visible = true;
                        AlumnosInscripciones alu = new AlumnosInscripciones(Global.Pers.ID);
                        //AlumnosInscripciones.ID = Convert.ToInt32(cbAlumnos.SelectedValue);
                        alu.ShowDialog();
                        lblCurso.Visible = false;
                        cbCursos.Visible = false;
                        //AlumnoInscripcionLogic auil = new AlumnoInscripcionLogic();
                        //cbAlumnos.DataSource = auil.GetAlumnos();
                        //cbAlumnos.ValueMember = "id_persona";
                        //cbAlumnos.DisplayMember = "legajo";
                        //cbAlumnos.ValueMember = "id_persona";

                        break;
                    }
                default:
                    {
                        cbAlumnos.Visible = false;
                        lblElegir.Visible = false;
                        lblCurso.Visible = false;
                        cbCursos.Visible = false;
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
            AlumnosInscripciones alu = new AlumnosInscripciones(Global.Pers.ID);
            //AlumnosInscripciones.ID = Convert.ToInt32(cbAlumnos.SelectedValue);
            alu.ShowDialog();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DocenteCursoLogic dl = new DocenteCursoLogic();
            cbAlumnos.DataSource = dl.GetCursoss(Global.Pers.ID);
            cbAlumnos.DisplayMember = "id_curso";
            cbAlumnos.ValueMember = "id_curso";
        }

        private void cbCursos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargaNotas cn = new CargaNotas(Convert.ToInt32(cbCursos.SelectedValue));
            cn.ShowDialog();

        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteCursos rc = new ReporteCursos();
            rc.ShowDialog();
        }

        private void planesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportePlanes rp = new ReportePlanes();
            rp.ShowDialog();
        }
    }
}
