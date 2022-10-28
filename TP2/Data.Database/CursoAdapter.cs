using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class CursoAdapter : Adapter
    {

        public DataTable GetMaterias()
        {
            DataTable materias = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select id_materia, desc_materia from materias", sqlConn);
                SqlDataAdapter daMateria = new SqlDataAdapter(cmdMateria);
                daMateria.Fill(materias);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de materias", Ex);
                throw Ex;
            }
            finally { this.CloseConnection(); }

            return materias;
        }

        public DataTable GetComisiones()
        {
            DataTable comisiones = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select id_comision, desc_comision from comisiones", sqlConn);
                SqlDataAdapter daComision = new SqlDataAdapter(cmdComision);
                daComision.Fill(comisiones);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de comisiones", Ex);
                throw Ex;
            }
            finally { this.CloseConnection(); }

            return comisiones;
        }


        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos " +
                    "join comisiones on comisiones.id_comision = cursos.id_comision " +
                    "join planes on planes.id_plan = comisiones.id_plan " +
                    "join materias on materias.id_materia = cursos.id_materia " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad "
                , this.sqlConn);
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Curso cur = new Curso();
                    Materia mat = new Materia();
                    Comision com = new Comision();
                    Plan plan = new Plan();
                    Especialidad esp = new Especialidad();
                    cur.Cupo = (int)drCurso["cupo"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    com.ID = (int)drCurso["id_comision"];
                    com.Descripcion = (string)drCurso["desc_comision"];
                    com.AnioEspecialidad = (int)drCurso["anio_especialidad"];
                    plan.ID = (int)drCurso["id_plan"];
                    plan.Descripcion = (string)drCurso["desc_plan"];
                    esp.ID = (int)drCurso["id_especialidad"];
                    esp.Descripcion = (string)drCurso["desc_especialidad"];
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.ID = (int)drCurso["id_curso"];
                    plan.Especialidad = esp;
                    mat.PLan = plan;
                    com.Plan = plan;
                    cur.Comision = com;
                    cur.Materia = mat;
                    cursos.Add(cur);
                }
                drCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            Materia mat = new Materia();
            Comision com = new Comision();
            Plan plan = new Plan();
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos " +
                    "join comisiones on comisiones.id_comision = cursos.id_comision " +
                    "join materias on materias.id_materia = cursos.id_materia " +
                    "join planes on planes.id_plan = comisiones.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad " + 
                    " where id_curso = @id"
                , this.sqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    cur.Cupo = (int)drCurso["cupo"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    com.ID = (int)drCurso["id_comision"];
                    com.Descripcion = (string)drCurso["desc_comision"];
                    com.AnioEspecialidad = (int)drCurso["anio_especialidad"];
                    plan.ID = (int)drCurso["id_plan"];
                    plan.Descripcion = (string)drCurso["desc_plan"];
                    esp.ID = (int)drCurso["id_especialidad"];
                    esp.Descripcion = (string)drCurso["desc_especialidad"];
                    plan.Especialidad = esp;
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.ID = (int)drCurso["id_curso"];
                    plan.Especialidad = esp;
                    mat.PLan = plan;
                    com.Plan = plan;
                    cur.Comision = com;
                    cur.Materia = mat;
                    drCurso.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso = @id", this.sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al eliminar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE cursos SET id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "WHERE id_curso = @id", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.VarChar, 50).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO dbo.cursos(id_materia, id_comision, anio_calendario, cupo) " +
                    "values(@id_materia, @id_comision, @anio_calendario, @cupo) " +
                    "select @@identity", this.sqlConn);
                cmdSave.Parameters.Add("@id_materia", SqlDbType.VarChar, 50).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                curso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al crear el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

        public void CambiaCupo(Curso curso, int cant)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE cursos SET id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "WHERE id_curso = @id", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.VarChar, 50).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo + cant;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        //public DataTable GetCursosDocente(int id_per)
        //{
        //    DataTable cursos = new DataTable();
        //    try
        //    {
        //        this.OpenConnection();
        //        SqlCommand cmd = new SqlCommand("select id_curso from docentes_cursos where id_docente=@id_doce ", sqlConn);
        //        cmd.Parameters.Add("@id_doce", SqlDbType.Int).Value = id_per;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(cursos);
        //    }

        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada =
        //        new Exception("Error al recuperar lista de cursos", Ex);
        //        throw Ex;
        //    }
        //    finally
        //    {
        //        this.CloseConnection();
        //    }
        //    return cursos;
        //}
    }
}
