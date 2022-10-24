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
    public partial class DocentesCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (((Persona.TiposPersonas)Session["tipo"] == Persona.TiposPersonas.Admin))
                {
                    this.LoadGrid();
                    formPanel.Visible = false;
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
                
            }
        }

        DocenteCursoLogic _logic;

        private DocenteCursoLogic Logic
        {
            get
            {
                if(_logic == null) { _logic = new DocenteCursoLogic();  };
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

        private DocenteCurso Entity
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
            this.IDCursoDropDownList.SelectedValue = this.Entity.IDCurso.ToString();
            this.IDDocenteDropDownList.SelectedValue = this.Entity.IDDocente.ToString();
            this.CargoDropDownList.SelectedValue = this.Entity.Cargo.ToString();
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

        private void LoadEntity(DocenteCurso docur)
        {
            docur.IDCurso = Convert.ToInt32(this.IDCursoDropDownList.SelectedValue);
            docur.IDDocente = Convert.ToInt32(this.IDDocenteDropDownList.SelectedValue);
            docur.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), this.CargoDropDownList.SelectedValue);
        }

        private void EnableForm(bool Enable)
        {
            this.IDCursoDropDownList.Enabled = Enable;
            this.IDDocenteDropDownList.Enabled = Enable;
            this.CargoDropDownList.Enabled = Enable;
            IDCursoDropDownList.DataSource = Logic.GetCursos();
            IDCursoDropDownList.DataValueField = "id_curso";
            IDCursoDropDownList.DataTextField = "id_curso";
            IDCursoDropDownList.DataBind();
            IDDocenteDropDownList.DataSource = Logic.GetDocentes();
            IDDocenteDropDownList.DataValueField = "id_persona";
            IDDocenteDropDownList.DataTextField = "nape";
            IDDocenteDropDownList.DataBind();
            CargoDropDownList.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));
            CargoDropDownList.DataBind();
            UpdateDatosCurso();
        }

        public void UpdateDatosCurso()
        {
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(Convert.ToInt32(this.IDCursoDropDownList.SelectedValue));
            MateriaLogic ml = new MateriaLogic();
            Materia mat = ml.GetOne(cur.IDMateria);
            MateriaLabel.Text = mat.Descripcion;
            ComisionLogic col = new ComisionLogic();
            Comision com = col.GetOne(cur.IDComision);
            ComisionLabel.Text = com.Descripcion;
            ComisionLabel.DataBind(); MateriaLabel.DataBind();
        }
        private void SaveEntity(DocenteCurso docur)
        {
            this.Logic.Save(docur);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new DocenteCurso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new DocenteCurso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
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
            formPanel.Visible = false;
        }

        protected void IDCursoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatosCurso();
        }

    }
}