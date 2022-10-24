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
        static class Global
        {
            public static int ID;
        }
        public CargaNotas(int id_cur)
        {
            InitializeComponent();
            Global.ID = id_cur;
            Listar();
        }

        private void CargaNotas_Load(object sender, EventArgs e)
        {
            Listar();
        }



        public void Listar()
        {
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            dgvNotas.DataSource = ail.GetAlumnosCurso(Global.ID);
            
        }

        private void dgvNotas_Click(object sender, EventArgs e)
        {
            int IDAlu= ((Business.Entities.AlumnoInscripcion)this.dgvNotas.SelectedRows[0].DataBoundItem).IDAlumno;
            int ID = ((Business.Entities.AlumnoInscripcion)this.dgvNotas.SelectedRows[0].DataBoundItem).ID;
            PersonaLogic per = new PersonaLogic();
            Business.Entities.Persona persona = per.GetOne(IDAlu);
            string nape = persona.Nombre + persona.Apellido;
            txtNombreAlumno.Text = nape;
            AlumnoInscripcionLogic alu = new AlumnoInscripcionLogic();
            Business.Entities.AlumnoInscripcion alumno = alu.GetOne(ID);
            cbCondicion.SelectedValue = alumno.Condicion;
            nNota.Value = alumno.Nota;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)this.dgvNotas.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionLogic alu = new AlumnoInscripcionLogic();
            Business.Entities.AlumnoInscripcion alumno = alu.GetOne(ID);
            alumno.Nota = Convert.ToInt32(nNota.Value);
            alumno.Condicion = cbCondicion.SelectedItem.ToString();
            alu.Update(alumno);
            Listar()
;        }
    }
}
