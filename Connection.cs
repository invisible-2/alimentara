using System.Configuration;

namespace Alimentara
{
    class Connection
    {
        public static string ConString(string numeCon)
        {
            return ConfigurationManager.ConnectionStrings[numeCon].ConnectionString;
        }
    }
}
