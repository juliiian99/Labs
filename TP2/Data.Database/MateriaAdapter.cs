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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias", this.sqlConn);
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                while (drMateria.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = (int)drMateria["id_materia"];
                    mat.Descripcion = (string)drMateria["desc_materia"];
                    mat.HSSemanales = (int)drMateria["hs_semanales"];
                    mat.HSTotales = (int)drMateria["hs_totales"];
                    mat.IDPlan = (int)drMateria["id_plan"];
                    materias.Add(mat);
                }
                drMateria.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias where id_materia = @id", this.sqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                if (drMateria.Read())
                {
                    mat.ID = (int)drMateria["id_materia"];
                    mat.Descripcion = (string)drMateria["desc_materia"];
                    mat.HSSemanales = (int)drMateria["hs_semanales"];
                    mat.HSTotales = (int)drMateria["hs_totales"];
                    mat.IDPlan = (int)drMateria["id_plan"];
                    drMateria.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia = @id", this.sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al eliminar la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE materias SET desc_materia = @desc_materia, hs_semanales = @hs_semanales, hs_totales = @hs_totales, id_plan = @id_plan  " +
                    "WHERE id_materia = @id", this.sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO dbo.materias(desc_materia, hs_semanales, hs_totales, id_plan) " +
                    "values(@desc_materia, @hs_semanales, @hs_totales, @id_plan) " +
                    "select @@identity", this.sqlConn);
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                materia.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al crear la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
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
