using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using Data.Database;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll(int id)
        {
            List<AlumnoInscripcion> alumnosinsc = new List<AlumnoInscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from alumnos_inscripciones where id_alumno= @id", sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AlumnoInscripcion alui = new AlumnoInscripcion();
                    alui.ID = (int)dr["id_inscripcion"];
                    alui.IDAlumno = (int)dr["id_alumno"];
                    alui.IDCurso = (int)dr["id_curso"];
                    alui.Condicion = (string)dr["condicion"];
                    alui.Nota = (int)dr["nota"];
                    alumnosinsc.Add(alui);
                }

                dr.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de inscripciones alumnos", Ex);
            }
            finally { this.CloseConnection(); }

            return alumnosinsc;
        }

        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion alui = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion = @id", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.Read())
                {
                    alui.ID = (int)dr["id_inscripcion"];
                    alui.IDAlumno = (int)dr["id_alumno"];
                    alui.IDCurso = (int)dr["id_curso"];
                    alui.Condicion = (string)dr["condicion"];
                    alui.Nota = (int)dr["nota"];
                    dr.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar el alumno inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alui;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete alumnos_inscripciones where id_inscripcion = @id", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al eliminar la inscripcion del alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(AlumnoInscripcion alui)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, id_curso= @id_curso, condicion = @condicion, " +
                    "nota = @nota WHERE id_inscripcion = @id", this.sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = alui.ID;
                cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alui.IDAlumno;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = alui.IDCurso;
                cmd.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alui.Condicion;
                cmd.Parameters.Add("@nota", SqlDbType.Int).Value = alui.Nota;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(AlumnoInscripcion alui)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd= new SqlCommand(
                    "insert into alumnos_inscripciones(id_curso, id_alumno, condicion, nota)" +
                    "values(@id_curso, @id_alumno, @condicion, @nota)" +
                    "select @@identity", sqlConn);
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = alui.IDCurso;
                cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alui.IDAlumno;
                cmd.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alui.Condicion;
                cmd.Parameters.Add("@nota", SqlDbType.Int).Value = alui.Nota;
                alui.ID = Decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la inscripcion del alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(AlumnoInscripcion alui)
        {
            if (alui.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alui.ID);
            }
            else if (alui.State == BusinessEntity.States.New)
            {
                this.Insert(alui);
            }
            else if (alui.State == BusinessEntity.States.Modified)
            {
                this.Update(alui);
            }
            alui.State = BusinessEntity.States.Unmodified;
        }

        public DataTable GetCursos(int id)
        {
            DataTable cursos = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select id_curso, id_materia, id_comision from cursos where id_curso not in(select id_curso from alumnos_inscripciones where id_alumno= @id )", sqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter ca = new SqlDataAdapter(cmd);
                ca.Fill(cursos);
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

        public DataTable GetAlumnos()
        {
            DataTable alumnos = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select id_persona,legajo, concat( nombre,' ', apellido)nape from personas where tipo_persona=1", sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(alumnos);
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
            return alumnos;
        }

        public DataTable GetAlumnosCurso(int id_c)
        {
            DataTable alumnos = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select id_alumno, id_curso, condicion,nota from alumnos_inscripciones where id_curso=@id_curso", sqlConn);
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = id_c;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(alumnos);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de alumnos", Ex);
                throw Ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnos;
        }


    }
}
