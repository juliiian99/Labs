using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        const string consKeyDefaultCnnString = "ConnStringLocal";
        protected SqlConnection sqlConn;

        protected void OpenConnection()
        {
            this.sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            this.sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
