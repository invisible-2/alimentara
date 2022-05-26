using System;
using System.Data.SqlClient;

namespace Alimentara
{
    class Conectare
    {
        SqlConnection sqlConnection;

        public Conectare()
        {
            sqlConnection = new SqlConnection("Server=DANIELL\\SQLEXPRESS;Database=AlimentaraBD;Trusted_Connection=True;");
        }

        public SqlConnection Open()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception) { }
            return sqlConnection;
        }

        public void Close()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception) { } 
        }
    }
}
