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
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((Persona.TiposPersonas)Session["tipo"] == Persona.TiposPersonas.Admin))
            {
                this.gridView.DataSource = this.Logic.GetAll();
                this.gridView.DataBind();
                gridView.Visible = true;
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            
            //Response.Redirect()
        }

        CursoLogic _logic;
        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
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

        private Curso Entity
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
            this.materiaDropDownList.SelectedValue = this.Entity.IDMateria.ToString();
            this.comisionDropDownList.SelectedValue = this.Entity.IDComision.ToString();
            this.anioCalendarioTextBox.Text = this.Entity.AnioCalendario.ToString();
            this.cupoTextBox.Text = this.Entity.Cupo.ToString();
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
            materiaDropDownList.DataSource = this.Logic.GetMaterias();
            materiaDropDownList.DataValueField = "id_materia";
            materiaDropDownList.DataTextField = "desc_materia";
            materiaDropDownList.DataBind();
            this.comisionDropDownList.Enabled = Enable;
            comisionDropDownList.DataSource = this.Logic.GetComisiones();
            comisionDropDownList.DataValueField = "id_comision";
            comisionDropDownList.DataTextField = "desc_comision";
            comisionDropDownList.DataBind();
            this.materiaDropDownList.Enabled = Enable;
            this.anioCalendarioTextBox.Enabled = Enable;
            this.cupoTextBox.Enabled = Enable;
        }

        private void LoadEntity(Curso curso)
        {
            curso.IDMateria = Convert.ToInt32(this.materiaDropDownList.SelectedValue);
            curso.IDComision = Convert.ToInt32(this.comisionDropDownList.SelectedValue);
            curso.AnioCalendario = Convert.ToInt32(this.anioCalendarioTextBox.Text);
            curso.Cupo = Convert.ToInt32(this.cupoTextBox.Text);
        }

        private void SaveEntity(Curso curso)
        {
            this.Logic.Save(curso);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Curso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
                case FormModes.Alta:
                    this.Entity = new Curso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);

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
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.anioCalendarioTextBox.Text = string.Empty;
            this.cupoTextBox.Text = string.Empty;
            //this.especialidadDropDownList.SelectedValue = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}