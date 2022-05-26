using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Alimentara
{
    class OperatiiBDLogIN
    {
        public List<Admin> getAdminByID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Admin>("getAdminByID @ID",
                    new { ID = id }).ToList();


                connection.Close();
                return output;
            }
        }
        public void AddUser(string username, string fname, string lname, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                List<User> user = new List<User>();

                user.Add(new User
                {
                    Username = username,
                    FName = fname,
                    LName = lname,
                    Pass = password
                });

                connection.Execute("addUser @username, @fname, @lname, @pass",
                    user);

                connection.Close();
            }
        }
        public List<String> CheckIfExistUser(string uername)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<String>("checkIfExistsUser @username",
                    new { Username = uername }).ToList();


                connection.Close();
                return output;
            }
        }

        public List<User> GetUserByUsername(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<User>("GetUserByUsername @username",
                    new { Username = username }).ToList();


                connection.Close();
                return output;
            }
        }

        public List<Admin> GetAdminByUsername(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Admin>("GetAdminByUsername @username",
                    new { Username = username }).ToList();


                connection.Close();
                return output;
            }
        }
    }
}
