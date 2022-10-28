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
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand(
                    "select * from personas " +
                    "join planes on personas.id_plan = planes.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad "
                , sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Persona persona = new Persona();
                    Plan plan = new Plan();
                    Especialidad esp = new Especialidad();
                    persona.ID = (int)drPersonas["id_persona"];
                    persona.Legajo = (int)drPersonas["legajo"];
                    persona.Apellido = (string)drPersonas["apellido"];
                    persona.Nombre = (string)drPersonas["nombre"];
                    persona.Direccion = (string)drPersonas["direccion"];
                    persona.EMail = (string)drPersonas["email"];
                    persona.Telefono = (string)drPersonas["telefono"];
                    persona.FechaNacimiento = Convert.ToDateTime(drPersonas["fecha_nac"]);
                    persona.IDPlan = (int)drPersonas["id_plan"];
                    plan.ID = (int)drPersonas["id_plan"];
                    plan.Descripcion = (string)drPersonas["desc_plan"];
                    esp.ID = (int)drPersonas["id_plan"];
                    esp.Descripcion = (string)drPersonas["desc_especialidad"];
                    plan.Especialidad = esp;
                    persona.Plan = plan;
                    persona.TipoPersona = (Persona.TiposPersonas)(drPersonas["tipo_persona"]);
                    personas.Add(persona);
                }
                drPersonas.Close();
            }
            catch
            {
                Exception Ex = new Exception("Error al recuperar personas");
                throw Ex;
            }
            finally
            {
                CloseConnection();
            }
            return personas;
        }

        public Persona GetOne(int ID)
        {
            Persona per = new Persona();
            Plan plan = new Plan();
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select personas.*, especialidades.*, planes.* from personas " +
                    "join planes on personas.id_plan = planes.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad " +
                    "where personas.id_persona = @id"
                , this.sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.EMail = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (Persona.TiposPersonas)(int)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    plan.ID = (int)drPersonas["id_plan"];
                    plan.Descripcion = (string)drPersonas["desc_plan"];
                    esp.ID = (int)drPersonas["id_plan"];
                    esp.Descripcion = (string)drPersonas["desc_especialidad"];
                    plan.Especialidad = esp;
                    per.Plan = plan;
                    drPersonas.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDeleteUsuario = new SqlCommand("delete usuarios where id_persona = @id", this.sqlConn);
                cmdDeleteUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlCommand cmdDeletePersona = new SqlCommand("delete personas where id_persona = @id", this.sqlConn);
                cmdDeletePersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDeleteUsuario.ExecuteNonQuery();
                cmdDeletePersona.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al eliminar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE personas SET nombre = @nombre, apellido= @apellido, direccion=@direccion, email = @email, telefono = @telefono, " +
                    "fecha_nac= @fecha_nac, legajo = @legajo, tipo_persona = @tipo_persona, id_plan= @id_plan "+
                    "WHERE id_persona = @id", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.EMail;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = Convert.ToInt32(persona.TipoPersona);
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO dbo.personas(nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) " +
                    "values(@nombre, @apellido, @direccion, @email, @telefono, @fecha_nac, @legajo, @tipo_persona, @id_plan) " +
                    "select @@identity", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.EMail;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TipoPersona;               
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                persona.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al crear la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

        public DataTable GetPlanes()
        {
            DataTable planes = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("select id_plan, desc_plan from planes", sqlConn);
                SqlDataAdapter daMateria = new SqlDataAdapter(cmdPlan);
                daMateria.Fill(planes);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de planes", Ex);
                throw Ex;
            }
            finally { this.CloseConnection(); }

            return planes;
        }

        public Persona GetLast()
        {
            Persona per = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select TOP 1 * from personas order by id_persona desc", this.sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.EMail = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (Persona.TiposPersonas)(int)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    drPersonas.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }

    }
}
