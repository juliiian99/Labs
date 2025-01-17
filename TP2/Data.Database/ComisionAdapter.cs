﻿using System;
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
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand(
                    "select planes.*, comisiones.*, especialidades.* from comisiones " +
                    "join planes on planes.id_plan = comisiones.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad"
                , this.sqlConn);
                SqlDataReader drComision = cmdComision.ExecuteReader();
                while (drComision.Read())
                {
                    Comision com = new Comision();
                    Plan plan = new Plan();
                    Especialidad esp = new Especialidad();
                    com.ID = (int)drComision["id_comision"];
                    com.Descripcion = (string)drComision["desc_comision"];
                    com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    com.IDPlan = (int)drComision["id_plan"];
                    plan.ID = (int)drComision["id_plan"];
                    plan.Descripcion = (string)drComision["desc_plan"];
                    esp.ID = (int)drComision["id_especialidad"];
                    esp.Descripcion = (string)drComision["desc_especialidad"];
                    plan.Especialidad = esp;
                    com.Plan = plan;
                    comisiones.Add(com);
                }
                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }

        public Comision GetOne(int ID)
        {
            Comision com = new Comision();
            Plan plan = new Plan();
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones " +
                    "join planes on planes.id_plan = comisiones.id_plan " +
                    "join especialidades on especialidades.id_especialidad = planes.id_especialidad " +
                    "where comisiones.id_comision = @id", this.sqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision.Read())
                {
                    com.ID = (int)drComision["id_comision"];
                    com.Descripcion = (string)drComision["desc_comision"];
                    com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    com.IDPlan = (int)drComision["id_plan"];
                    plan.ID = (int)drComision["id_plan"];
                    plan.Descripcion = (string)drComision["desc_plan"];
                    esp.ID = (int)drComision["id_especialidad"];
                    esp.Descripcion = (string)drComision["desc_especialidad"];
                    plan.Especialidad = esp;
                    com.Plan = plan;
                    drComision.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision = @id", this.sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al eliminar la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE comisiones SET desc_comision = @desc_comision, anio_especialidad = @anio_especialidad, id_plan = @id_plan  " +
                    "WHERE id_comision = @id", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO dbo.comisiones(desc_comision, anio_especialidad, id_plan) " +
                    "values(@desc_comision, @anio_especialidad, @id_plan) " +
                    "select @@identity", this.sqlConn);
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;
                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al crear la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
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
    }
}
