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
    public partial class CargaNotas : Form
    {
        public CargaNotas(int id_cur)
        {
            InitializeComponent();
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            dgvNotas.DataSource = ail.GetAlumnosCurso(id_cur);
        }

        private void CargaNotas_Load(object sender, EventArgs e)
        {
            //AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            //dgvNotas.DataSource = ail.GetAll();
        }
    }
}
