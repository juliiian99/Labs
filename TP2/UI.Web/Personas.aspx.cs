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
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.LoadGrid();
                formPanel.Visible = false;
            }
        }

        PersonaLogic _logic;
        private PersonaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonaLogic();
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

        private Persona Entity
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
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.emailTextBox.Text = this.Entity.EMail;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.fNacCalendar.SelectedDate = this.Entity.FechaNacimiento;
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.tipoPersonaDropDownList.SelectedValue = this.Entity.TipoPersona.ToString();
            this.planDropDownList.SelectedValue = this.Entity.IDPlan.ToString();
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

        private void LoadEntity(Persona persona)
        {
            persona.Nombre = this.nombreTextBox.Text;
            persona.Apellido = this.apellidoTextBox.Text;
            persona.Direccion = this.direccionTextBox.Text;
            persona.EMail = this.emailTextBox.Text;
            persona.Telefono = this.telefonoTextBox.Text;
            persona.FechaNacimiento = this.fNacCalendar.SelectedDate;
            persona.Legajo = Convert.ToInt32(this.legajoTextBox.Text);
            persona.IDPlan = Convert.ToInt32(this.planDropDownList.SelectedValue);
            persona.TipoPersona = (Persona.TiposPersonas)Enum.Parse(typeof(Persona.TiposPersonas), this.tipoPersonaDropDownList.SelectedValue);
        }

        private void EnableForm(bool Enable)
        {
            this.nombreTextBox.Enabled = Enable;
            this.apellidoTextBox.Enabled = Enable;
            this.direccionTextBox.Enabled = Enable;
            this.emailTextBox.Enabled = Enable;
            this.telefonoTextBox.Enabled = Enable;
            this.fNacCalendar.Enabled = Enable;
            this.legajoTextBox.Enabled = Enable;
            this.tipoPersonaDropDownList.Enabled = Enable;
            tipoPersonaDropDownList.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));
            tipoPersonaDropDownList.DataBind();
            this.planDropDownList.Enabled = Enable;
            planDropDownList.DataSource = this.Logic.GetPlanes();
            planDropDownList.DataValueField = "id_plan";
            planDropDownList.DataTextField = "desc_plan";
            planDropDownList.DataBind();

        }
        private void SaveEntity(Persona persona)
        {
            this.Logic.Save(persona);
        }

        private void AddUsuario()
        {
            PersonaLogic p = new PersonaLogic();
            Business.Entities.Persona per = p.GetLast();
            string no = per.Nombre; string ape = per.Apellido; string mail = per.EMail; int id = per.ID;
            Response.Redirect("~/Usuarios.aspx?nombre=" + per.Nombre + "&apellido=" + per.Apellido + "&email=" + per.EMail + "&id_per=" + per.ID);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            if ((fNacCalendar.SelectedDate.Date.Year)<1900)
            {
                Response.Write("Seleccione una fecha de nacimiento valida");
            }
            else
            {
                switch (this.FormMode)
                {
                    case FormModes.Baja:
                        this.DeleteEntity(this.SelectedID);
                        this.LoadGrid();
                        break;
                    case FormModes.Modificacion:
                        this.Entity = new Persona();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    case FormModes.Alta:
                        this.Entity = new Persona();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.AddUsuario();
                        this.LoadGrid();
                        break;
                    default:
                        break;
                }
                this.formPanel.Visible = false;
            }
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
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            // this.fNacCalendar.SelectedDate = string.Empty;
            this.legajoTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}