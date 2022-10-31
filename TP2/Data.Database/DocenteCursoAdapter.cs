using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docentesCursos = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select id_docente, docentes_cursos.id_curso, id_dictado, cargo, concat(desc_comision, ' ', desc_materia, ' ', anio_especialidad)cur, " +
                    "concat(nombre, ' ', apellido)nape from docentes_cursos " +
                    "join cursos on cursos.id_curso = docentes_cursos.id_curso " +
                    "join personas on personas.id_persona = docentes_cursos.id_docente " +
                    "join comisiones on comisiones.id_comision = cursos.id_comision " +
                    "join materias on materias.id_materia = cursos.id_materia " +
                    "join planes on planes.id_plan = comisiones.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad "
                , this.sqlConn);
                SqlDataReader dr= cmd.ExecuteReader();
                while (dr.Read())
                {
                    DocenteCurso docur = new DocenteCurso();
                    Persona per = new Persona();
                    Comision com = new Comision();
                    Materia mat = new Materia();
                    Curso cur = new Curso();
                    Plan plan = new Plan();
                    Especialidad esp = new Especialidad();
                    docur.ID = (int)dr["id_dictado"];
                    docur.IDCurso = (int)dr["id_curso"];
                    docur.IDDocente = (int)dr["id_docente"];
                    docur.Cargo = (DocenteCurso.TiposCargos)dr["cargo"];
                    docur.Curso = (string)dr["cur"];
                    docur.Docente = (string)dr["nape"];
                    //cur.Cupo = (int)dr["cupo"];
                    //cur.AnioCalendario = (int)dr["anio_calendario"];
                    //cur.IDComision = (int)dr["id_comision"];
                    //com.ID = (int)dr["id_comision"];
                    //com.Descripcion = (string)dr["desc_comision"];
                    //com.AnioEspecialidad = (int)dr["anio_especialidad"];
                    //plan.ID = (int)dr["id_plan"];
                    //plan.Descripcion = (string)dr["desc_plan"];
                    //esp.ID = (int)dr["id_especialidad"];
                    //esp.Descripcion = (string)dr["desc_especialidad"];
                    //plan.Especialidad = esp;
                    //cur.IDMateria = (int)dr["id_materia"];
                    //cur.ID = (int)dr["id_curso"];
                    //cur.Materia = mat;
                    //per.ID = (int)dr["id_persona"];
                    //per.Legajo = (int)dr["legajo"];
                    //per.Apellido = (string)dr["apellido"];
                    //per.Nombre = (string)dr["nombre"];
                    //per.Direccion = (string)dr["direccion"];
                    //per.EMail = (string)dr["email"];
                    //per.Telefono = (string)dr["telefono"];
                    //per.FechaNacimiento = Convert.ToDateTime(dr["fecha_nac"]);
                    //per.IDPlan = (int)dr["id_plan"];
                    //cur.Comision = com;
                    //mat.PLan = plan;
                    //docur.Curso = cur;
                    //docur.Docente = per;
                    docentesCursos.Add(docur);
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de cursos de docentes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentesCursos;
        }

        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso docur = new DocenteCurso();
            Persona per = new Persona();
            Comision com = new Comision();
            Materia mat = new Materia();
            Curso cur = new Curso();
            Plan plan = new Plan();
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select id_docente, docentes_cursos.id_curso, id_dictado, cargo, concat(desc_comision, ' ', desc_materia, ' ', anio_especialidad)cur, " +
                    "concat(nombre, ' ', apellido)nape from docentes_cursos " +
                    "join cursos on cursos.id_curso = docentes_cursos.id_curso " +
                    "join personas on personas.id_persona = docentes_cursos.id_docente " +
                    "join comisiones on comisiones.id_comision = cursos.id_comision " +
                    "join materias on materias.id_materia = cursos.id_materia " +
                    "join planes on planes.id_plan = comisiones.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad "+
                    "where id_dictado=@id"
                , this.sqlConn);
                // SqlCommand cmd = new SqlCommand("select * from docentes_cursos where id_dictado = @id", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    docur.ID = (int)dr["id_dictado"];
                    docur.IDCurso = (int)dr["id_curso"];
                    docur.IDDocente = (int)dr["id_docente"];
                    docur.Cargo = (DocenteCurso.TiposCargos)dr["cargo"];
                    docur.Curso = (string)dr["cur"];
                    docur.Docente = (string)dr["nape"];
                    //cur.Cupo = (int)dr["cupo"];
                    //cur.AnioCalendario = (int)dr["anio_calendario"];
                    //cur.IDComision = (int)dr["id_comision"];
                    //com.ID = (int)dr["id_comision"];
                    //com.Descripcion = (string)dr["desc_comision"];
                    //com.AnioEspecialidad = (int)dr["anio_especialidad"];
                    //plan.ID = (int)dr["id_plan"];
                    //plan.Descripcion = (string)dr["desc_plan"];
                    //esp.ID = (int)dr["id_especialidad"];
                    //esp.Descripcion = (string)dr["desc_especialidad"];
                    //plan.Especialidad = esp;
                    //cur.IDMateria = (int)dr["id_materia"];
                    //cur.ID = (int)dr["id_curso"];
                    //cur.Materia = mat;
                    //per.ID = (int)dr["id_persona"];
                    //per.Legajo = (int)dr["legajo"];
                    //per.Apellido = (string)dr["apellido"];
                    //per.Nombre = (string)dr["nombre"];
                    //per.Direccion = (string)dr["direccion"];
                    //per.EMail = (string)dr["email"];
                    //per.Telefono = (string)dr["telefono"];
                    //per.FechaNacimiento = Convert.ToDateTime(dr["fecha_nac"]);
                    //per.IDPlan = (int)dr["id_plan"];
                    //cur.Comision = com;
                    //mat.PLan = plan;
                    //docur.Curso = cur;
                    //docur.Docente = per;
                    dr.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docur;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete docentes_cursos where id_dictado = @id", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =new Exception("Error al eliminar el docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(DocenteCurso docur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE docentes_cursos SET id_curso = @id_curso, id_docente= @id_docente, cargo=@cargo " +
                    "WHERE id_dictado = @id", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = docur.ID;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = docur.IDCurso;
                cmd.Parameters.Add("@id_docente", SqlDbType.Int).Value = docur.IDDocente;
                cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = docur.Cargo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(DocenteCurso docur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.docentes_cursos(id_curso, id_docente, cargo) " +
                                                "values(@id_curso, @id_docente, @cargo) " +
                                                "select @@identity", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = docur.ID;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = docur.IDCurso;
                cmd.Parameters.Add("@id_docente", SqlDbType.Int).Value = docur.IDDocente;
                cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = docur.Cargo;
                docur.ID = Decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso docur)
        {
            if (docur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(docur.ID);
            }
            else if (docur.State == BusinessEntity.States.New)
            {
                this.Insert(docur);
            }
            else if (docur.State == BusinessEntity.States.Modified)
            {
                this.Update(docur);
            }
            docur.State = BusinessEntity.States.Unmodified;
        }

        public DataTable GetCursos()
        {
            DataTable cursos = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select cursos.id_curso, cursos.id_materia, cursos.id_comision, " +
                    "concat(materias.desc_materia,' ', comisiones.desc_comision,' ', cursos.anio_calendario)cur from cursos " +
                    "join comisiones on comisiones.id_comision = cursos.id_comision " +
                    "join materias on materias.id_materia = cursos.id_materia " 
                    , sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(cursos);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de cursos", Ex);
                throw Ex;
            }
            finally 
            { 
                this.CloseConnection(); 
            }
            return cursos;
        }

        public DataTable GetCursoss(int id_per)
        {
            DataTable cursos = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select docentes_cursos.id_curso, docentes_cursos.id_docente, " +
                    "concat(materias.desc_materia,' ', comisiones.desc_comision,' ', cursos.anio_calendario)cur from docentes_cursos " +
                    "join cursos on docentes_cursos.id_curso= cursos.id_curso " +
                    "join comisiones on comisiones.id_comision = cursos.id_comision " +
                    "join materias on materias.id_materia = cursos.id_materia " +
                    "where id_docente=@id_doce ", sqlConn);
                cmd.Parameters.Add("@id_doce", SqlDbType.Int).Value = id_per;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(cursos);
                //
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de cursos", Ex);
                throw Ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public DataTable GetDocentes()
        {
            DataTable docentes = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select id_persona,concat( nombre,' ', apellido)nape from personas where tipo_persona=0", sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(docentes);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de docentes", Ex);
                throw Ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentes;
        }

        
    }
}
