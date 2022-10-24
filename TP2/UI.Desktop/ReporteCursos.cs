using Business.Logic;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteCursos : Form
    {
        public ReporteCursos()
        {
            InitializeComponent();
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.cursos' Puede moverla o quitarla según sea necesario.
            //this.cursosTableAdapter.Fill(this.tp2_netDataSet.cursos);
            CursoLogic cl = new CursoLogic();
            ReportDataSource rds = new ReportDataSource("DataSet2", cl.GetAll());
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
