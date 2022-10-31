using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;

namespace UI.Web
{
    public partial class AlumnoInscripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((Persona.TiposPersonas)Session["tipo"] == Persona.TiposPersonas.Alumno))
            {
                this.gridView.DataSource = this.Logic.GetAll(Convert.ToInt32(Session["id_persona"]));
                this.gridView.DataBind();
                gridView.Visible = true;
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        AlumnoInscripcionLogic _logic;
        private AlumnoInscripcionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumnoInscripcionLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll(Convert.ToInt32(Session["id_persona"]));
            this.gridView.DataBind();
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Business.Entities.AlumnoInscripcion Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.condicionTextBox.Text = this.Entity.Condicion;
            this.notaTextBox.Text = this.Entity.Nota.ToString();
           // this.idCursoDropDownList.SelectedValue = this.Entity.IDCurso.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        private void EnableForm(bool Enable)
        {
            this.idCursoDropDownList.Enabled = Enable;
            idCursoDropDownList.DataSource = this.Logic.GetCursos(Convert.ToInt32(Session["id_persona"]));
            idCursoDropDownList.DataValueField = "id_curso";
            idCursoDropDownList.DataTextField = "cur";
            idCursoDropDownList.DataBind();
        }

        private void LoadEntity(Business.Entities.AlumnoInscripcion alui)
        {
            alui.Condicion = this.condicionTextBox.Text;
            alui.Nota = Convert.ToInt32(this.notaTextBox.Text);
            alui.IDCurso = Convert.ToInt32(this.idCursoDropDownList.SelectedValue);
            alui.IDAlumno = Convert.ToInt32(Session["id_persona"]);
        }

        private void SaveEntity(Business.Entities.AlumnoInscripcion alui)
        {
            this.Logic.Save(alui);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(Convert.ToInt32(idCursoDropDownList.SelectedValue));
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    int g = 1; cl.CambiaCupo(cur, g);
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.AlumnoInscripcion();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
                case FormModes.Alta:
                    if (cur.Cupo != 0)
                    {
                        this.Entity = new Business.Entities.AlumnoInscripcion();
                        this.LoadEntity(this.Entity);
                        int i = -1; cl.CambiaCupo(cur, i);
                        this.SaveEntity(this.Entity);
                    }else { Response.Write("No hay cupo");
                        break;
                    }

                    break;
                default:
                    break;
            }
            this.LoadGrid();
            this.formPanel.Visible = false;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.EnableForm(true);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}