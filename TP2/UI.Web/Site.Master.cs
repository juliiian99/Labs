using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                Persona.TiposPersonas tipo = (Persona.TiposPersonas)Session["tipo"];
                switch (tipo)
                {
                    case Business.Entities.Persona.TiposPersonas.Alumno:
                        PersonasVisible = false;
                        MateriasVisible = false;
                        UsuariosVisible = false;
                        CursosVisible = false;
                        ComisionesVisible = false;
                        PlanesVisible = false;
                        EspecialidadesVisible = false;
                        DocentesCursosVisible = false;
                        InscripcionAlumnoVisible = true;
                        break;
                    case Business.Entities.Persona.TiposPersonas.Docente:
                        PersonasVisible = false;
                        MateriasVisible = false;
                        UsuariosVisible = false;
                        CursosVisible = false;
                        ComisionesVisible = false;
                        PlanesVisible = false;
                        EspecialidadesVisible = false;
                        DocentesCursosVisible = false;
                        InscripcionAlumnoVisible = false;
                        break;
                    default: 
                        InscripcionAlumnoVisible = false;
                        break; 
                }
            }
        }

        public bool InscripcionAlumnoVisible
        {
            get { return inscripcionAlumnoLink.Visible; }
            set { inscripcionAlumnoLink.Visible = value; }
        }

        public bool PersonasVisible
        {
            get { return personasLink.Visible; }
            set { personasLink.Visible = value; }
        }

        public bool CursosVisible
        {
            get { return cursosLink.Visible; }
            set { cursosLink.Visible = value; }
        }

        public bool MateriasVisible
        {
            get { return materiasLink.Visible; }
            set { materiasLink.Visible = value; }
        }

        public bool UsuariosVisible
        {
            get { return usuariosLink.Visible; }
            set { usuariosLink.Visible = value; }
        }

        public bool PlanesVisible
        {
            get { return planesLink.Visible; }
            set { planesLink.Visible = value; }
        }

        public bool EspecialidadesVisible
        {
            get { return especialidadesLink.Visible; }
            set { especialidadesLink.Visible = value; }
        }

        public bool ComisionesVisible
        {
            get { return comisionesLink.Visible; }
            set { comisionesLink.Visible = value; }
        }

        public bool DocentesCursosVisible
        {
            get { return docenteCursoLink.Visible; }
            set { docenteCursoLink.Visible = value; }
        }
    }
}