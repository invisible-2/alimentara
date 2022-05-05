using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alimentara
{
    class Connection
    {
        private SqlConnection connection;
        public Connection()
        {
            connection = new SqlConnection("Data Source=DANIELL\\SQLEXPRESS; Initial Catalog=AlimentaraBD; Integrated Security=True");
        }

        public SqlConnection Connect()
        {
            try
            {
                connection.Open();
            }
            catch (Exception) { }

            return connection;
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();

            }catch(Exception) { }
        }
    }
}
