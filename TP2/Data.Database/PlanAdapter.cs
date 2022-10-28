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
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("SELECT planes.*, especialidades.* FROM planes JOIN especialidades on especialidades.id_especialidad = planes.id_especialidad", this.sqlConn);
                SqlDataReader drPlan = cmdPlan.ExecuteReader();
                while (drPlan.Read())
                {
                    Plan pla = new Plan();
                    Especialidad esp = new Especialidad();
                    pla.ID = (int)drPlan["id_plan"];
                    esp.ID = (int)drPlan["id_especialidad"];
                    esp.Descripcion = (string)drPlan["desc_especialidad"];
                    pla.Descripcion = (string)drPlan["desc_plan"];
                    pla.IDEspecialidad = (int)drPlan["id_especialidad"];
                    pla.Especialidad = esp;
                    planes.Add(pla);
                }
                drPlan.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return planes;
        }

        public Plan GetOne(int ID)
        {
            Plan pla = new Plan();
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("select planes.*, especialidades.* FROM planes " +
                    "JOIN especialidades on especialidades.id_especialidad = planes.id_especialidad " +
                    "where planes.id_plan = @id"
                , this.sqlConn);
                cmdPlan.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPlan = cmdPlan.ExecuteReader();
                if (drPlan.Read())
                {
                    pla.ID = (int)drPlan["id_plan"];
                    pla.Descripcion = (string)drPlan["desc_plan"];
                    pla.IDEspecialidad = (int)drPlan["id_especialidad"];
                    esp.ID = (int)drPlan["id_especialidad"];
                    esp.Descripcion = (string)drPlan["desc_especialidad"];
                    pla.Especialidad = esp;
                    drPlan.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar el plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return pla;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete =new SqlCommand("delete planes where id_plan = @id", this.sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al eliminar el plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes SET desc_plan = @desc_plan, id_especialidad = @id_especialidad " +
                    "WHERE id_plan = @id", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO dbo.planes(desc_plan, id_especialidad) " +
                    "values(@desc_plan, @id_especialidad) " +
                    "select @@identity", this.sqlConn);
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al crear el plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

        public DataTable GetEspecialidades()
        {
            DataTable especialidades = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select id_especialidad, desc_especialidad from especialidades", sqlConn);
                SqlDataAdapter daMateria = new SqlDataAdapter(cmdEspecialidad);
                daMateria.Fill(especialidades);
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de especialidades", Ex);
                throw Ex;
            }
            finally { this.CloseConnection(); }

            return especialidades;
        }

    }
}
