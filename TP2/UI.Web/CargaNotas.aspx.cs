using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class CargaNotas : System.Web.UI.Page
    {
        static class Global
        {
           static public Business.Entities.AlumnoInscripcion aluins;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (((Persona.TiposPersonas)Session["tipo"] == Persona.TiposPersonas.Docente))
                {
                    DocenteCursoLogic dl = new DocenteCursoLogic();
                    cursoDropDownList.DataSource = dl.GetCursoss(Convert.ToInt32(Session["id_persona"]));
                    cursoDropDownList.DataValueField = "id_curso";
                    cursoDropDownList.DataTextField = "id_curso";
                    cursoDropDownList.DataBind();
                    Session["id_cur"] = cursoDropDownList.SelectedValue;
                    this.gridView.DataBind();
                    gridView.Visible = true;
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
                
                
        }

        public void Listar()
        {
            Session["id_cur"] = cursoDropDownList.SelectedValue;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            gridView.DataSource = ail.GetAlumnosCurso(Convert.ToInt32(Session["id_cur"]));
            gridView.DataBind();
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

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        private Business.Entities.AlumnoInscripcion Entity
        {
            get;
            set;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridPanel.Visible = true;
            this.SelectedID = (int)this.gridView.SelectedValue;
            AlumnoInscripcionLogic al = new AlumnoInscripcionLogic();
            Global.aluins = al.GetOne(SelectedID);
            PersonaLogic p = new PersonaLogic();
            Business.Entities.Persona alumno = p.GetOne(Global.aluins.IDAlumno);
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.LoadForm(this.SelectedID);
            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.condicionDropDownList.Text = this.Entity.Condicion;
            this.notaTextBox.Text = this.Entity.Nota.ToString();
            // this.idCursoDropDownList.SelectedValue = this.Entity.IDCurso.ToString();
        }

        private void EnableForm(bool Enable)
        {
            this.condicionDropDownList.Enabled = Enable;
            this.notaTextBox.Enabled = Enable;
            this.idCursoDropDownList.Enabled = Enable;
            DocenteCursoLogic dl = new DocenteCursoLogic();
            idCursoDropDownList.DataSource = dl.GetCursoss(Convert.ToInt32(Session["id_persona"]));
            idCursoDropDownList.DataValueField = "id_curso";
            idCursoDropDownList.DataTextField = "cur";
            idCursoDropDownList.DataBind();
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            Listar();
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll(Convert.ToInt32(Session["id_persona"]));
            this.gridView.DataBind();
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            this.Entity = new Business.Entities.AlumnoInscripcion();
            this.Entity.ID = this.SelectedID;
            this.Entity.State = BusinessEntity.States.Modified;
            this.LoadEntity(this.Entity);
            this.SaveEntity(this.Entity);
            Listar();
            formPanel.Visible = false;
        }

        private void LoadEntity(Business.Entities.AlumnoInscripcion alui)
        {
            alui.Condicion = this.condicionDropDownList.Text;
            alui.Nota = Convert.ToInt32(this.notaTextBox.Text);
            alui.IDCurso = Convert.ToInt32(Session["id_cur"]);
            alui.IDAlumno = Global.aluins.IDAlumno;
        }

        private void SaveEntity(Business.Entities.AlumnoInscripcion alui)
        {
            this.Logic.Update(alui);
            Listar();
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}