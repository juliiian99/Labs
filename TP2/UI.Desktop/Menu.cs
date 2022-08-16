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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarioAbmc = new Usuarios();
            usuarioAbmc.ShowDialog();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidades especialidadAbmc = new Especialidades();
            especialidadAbmc.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias materiasAbmc = new Materias();
            materiasAbmc.ShowDialog();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            Comisiones comisionesAbmc = new Comisiones();
            comisionesAbmc.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Planes planAbmc = new Planes();
            planAbmc.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos cursoAbmc = new Cursos();
            cursoAbmc.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonaDesktop personaAbmc = new PersonaDesktop();
            personaAbmc.ShowDialog();
        }

        private void abmcPersonas_Click(object sender, EventArgs e)
        {
            Personas personaABMC = new Personas();
            personaABMC.ShowDialog();
        }
    }
}
