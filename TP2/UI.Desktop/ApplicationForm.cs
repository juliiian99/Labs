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
    public partial class ApplicationForm : Form
    {

        public ModoForm _Modo;

        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }
        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
        public virtual bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta,
            Modo
        }
        public ApplicationForm()
        {
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ApplicationForm
            // 
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Name = "ApplicationForm";
            this.ResumeLayout(false);

        }
    }
}
