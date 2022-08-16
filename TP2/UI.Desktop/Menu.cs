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
    }
}
