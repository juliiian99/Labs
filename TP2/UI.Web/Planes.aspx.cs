using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Planes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
            formPanel.Visible = false;
        }

        PlanLogic _logic;
        private PlanLogic Logic {
            get {
                if (_logic == null)
                {
                    _logic = new PlanLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Plan Entity {
            get;
            set;
        }

        private int SelectedID {
            get {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected {
            get {
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
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            // this.especialidadDropDownList.Text = this.Entity.IDEspecialidad;
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
            this.descripcionTextBox.Enabled = Enable;
            this.especialidadDropDownList.Enabled = Enable;
        }

        private void LoadEntity(Plan plan)
        {
            plan.Descripcion = this.descripcionTextBox.Text;
            plan.IDEspecialidad = int.Parse(this.especialidadDropDownList.SelectedValue);
        }

        private void SaveEntity(Plan plan)
        {
            this.Logic.Save(plan);
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
                    this.Entity = new Plan();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Plan();
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
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
            this.especialidadDropDownList.SelectedValue = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}